using Models;
using Rema1000;
using Rema1000.ReponseModels;
using Repositories;

namespace ActionHandlers;

public class ProduktHandler
{
    private readonly ProduktRepository Repository;
    // private readonly Rema1000Api RemaApi;

    public ProduktHandler()
    {
        Repository = new ProduktRepository();
    }

    public List<Produkt> GetAll()
    {
        return Repository.GetAll();
    }

    public List<Produkt> GetForCreate(List<int> existingIds, string search, int amount)
    {
        return Repository.GetForCreate(existingIds, search, amount);
    }

    public Produkt Create(string name, string note, PackingType packingType, Butik butik, double price, int grams, int calories, int? varenummer)
    {
        var produkt = new Produkt{
            Name = name,
            Note = note,
            PackingType = packingType,
            Price = price,
            Grams = grams,
            Calories = calories,
            Butik = butik,
            Varenummer = varenummer
        };

        produkt = Repository.Create(produkt);

        return produkt;
    }

    public void Delete(Produkt produkt)
    {
        Repository.Delete(produkt);
    }

    public async Task<RemaResponse>? GetProduktInfo(int varenummer)
    {
        var RemaApi = new Rema1000Api();
        return await RemaApi.GetProduktInfo(varenummer);
    }
}
