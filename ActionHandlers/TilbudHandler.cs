using Models;
using Rema1000;
using Rema1000.ReponseModels;
using Repositories;

namespace ActionHandlers;

public class TilbudHandler
{
    private readonly ProduktRepository _produktRepository;

    public TilbudHandler(ProduktRepository produktRepository)
    {
        _produktRepository = produktRepository;
    }

    public async Task<List<Produkt>> GetCurrentTilbud()
    {
        // Do not await -> will slow down page loading time
        _ = UpdateRemaTilbudAsync();

        var produkterMedTilbud = _produktRepository.GetProdukterMedTilbud();
        return produkterMedTilbud;
    }

    public async Task UpdateRemaTilbudAsync()
    {
        Console.WriteLine("UpdateRemaTilbudAsync");

        // 1. Get produkter ready to update tilbud data
        var produkterToUpdate = _produktRepository.GetProdukterToUpdateTilbud(20);

        // 2. Call Rema API
        var RemaApi = new Rema1000Api();
        foreach (var produkt in produkterToUpdate)
        {
            if (produkt.Varenummer == null) 
                continue;

            Console.WriteLine(produkt.Name);

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
                _produktRepository.Update(produkt);
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

            if (produkt.Name == "")
                produkt.Name = remaResponse.Name;

            if (produkt.Note == null)
                produkt.Note = remaResponse.Underline;

            if (produkt.Price == 0)
                produkt.Price = remaResponse.NormalPrice;

            if (produkt.Grams == 0 && remaResponse.Grams != null)
                produkt.Grams = (int) remaResponse.Grams;

            if (produkt.Calories == 0 && remaResponse.Calories != null)
                produkt.Calories = (int) remaResponse.Calories;

            // 3. Update produkt
            produkt.ImageUrl = remaResponse.Images.First().Medium;
            produkt.TilbudDataUpdatedAt = DateTime.Now;
            _produktRepository.Update(produkt);        
        }
    }
}
