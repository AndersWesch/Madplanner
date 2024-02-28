using Models;
using Rema1000;
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
        UpdateRemaTilbudAsync();
        
        var produkterMedTilbud = produktRepository.GetProdukterMedTilbud();
        return produkterMedTilbud;
    }

    public async Task UpdateRemaTilbudAsync()
    {
        // 1. Get produkter ready to update tilbud data
        var produkterToUpdate = produktRepository.GetProdukterToUpdateTilbud(5);

        // 2. Call Rema API
        var RemaApi = new Rema1000Api();
        foreach (var produkt in produkterToUpdate)
        {
            if (produkt.Varenummer == null) 
            {
                continue;
            }

            var remaResponse = await RemaApi.GetProduktInfo((int)produkt.Varenummer);
            
            Console.WriteLine(produkt.Name + " " + produkt.Varenummer);

            if (remaResponse == null)
            {
                continue;
            }

            // Måske der er flere?
            var tilbudPris = remaResponse.Prices.Where(p => p.IsCampaign).FirstOrDefault();

            if (tilbudPris != null)
            {
                Console.WriteLine("Tilbud " + tilbudPris.Price);

                produkt.TilbudPrice = tilbudPris.Price;
                //produkt.TilbudStartingAt = tilbudPris.StartingAt;
                //produkt.TilbudEndingAt = tilbudPris.EndingAt;
            }

            // TODO delete tilbud if gone

            // 3. Update produkt
            produkt.ImageUrl = remaResponse.Images.First().Medium;
            produkt.TilbudDataUpdatedAt = DateTime.Now;
            produktRepository.Update(produkt);        
        }
    }
}
