using Models;
using Rema1000;
using Rema1000.ReponseModels;
using Repositories;
using SQLitePCL;

namespace ActionHandlers;

public class TilbudHandler
{
    private readonly ProduktRepository produktRepository;

    public TilbudHandler()
    {
        produktRepository = new ProduktRepository();
    }

    public async Task<List<Produkt>> GetCurrentTilbud()
    {
        // Do not await -> will slow down page loading time
        UpdateRemaTilbudAsync();
        
        var produkterMedTilbud = produktRepository.GetProdukterMedTilbud();
        return produkterMedTilbud;
    }

    public async Task UpdateRemaTilbudAsync()
    {
        // 1. Get produkter ready to update tilbud data
        var produkterToUpdate = produktRepository.GetProdukterToUpdateTilbud(100);

        // 2. Call Rema API
        var RemaApi = new Rema1000Api();
        foreach (var produkt in produkterToUpdate)
        {
            if (produkt.Varenummer == null) 
                continue;

            // Remove tilbud if expired
            if (produkt.TilbudPrice != null)
            {
                DateTime dateTimeNow = DateTime.Now;
                if (dateTimeNow.AddDays(-1) > produkt.TilbudEndingAt)
                {
                    produkt.TilbudPrice = null;
                    produkt.TilbudStartingAt = null;
                    produkt.TilbudEndingAt = null;
                }
            }

            RemaResponse? remaResponse;

            try {
                // Get data from Rema API
                remaResponse = await RemaApi.GetProduktInfo((int)produkt.Varenummer);
            } catch {
                produkt.TilbudDataUpdatedAt = DateTime.Now;
                produktRepository.Update(produkt);
                continue;
            }
            
            if (remaResponse == null)
                continue;

            var tilbudPris = remaResponse.Prices.Where(p => p.IsCampaign).FirstOrDefault();

            if (tilbudPris != null)
            {
                Console.WriteLine(produkt.Name + " " + produkt.Varenummer);
                Console.WriteLine("Tilbud på "+ produkt.Name + " til  " + tilbudPris.Price);

                produkt.TilbudPrice = tilbudPris.Price;
                produkt.TilbudStartingAt = tilbudPris.StartingAt;
                produkt.TilbudEndingAt = tilbudPris.EndingAt;
            }

            // 3. Update produkt
            produkt.ImageUrl = remaResponse.Images.First().Medium;
            produkt.TilbudDataUpdatedAt = DateTime.Now;
            produktRepository.Update(produkt);        
        }
    }
}
