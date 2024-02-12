using Models;
using Repositories;

namespace ActionHandlers;

public class ProduktHandler
{
    private readonly ProduktRepository Repository;

    public ProduktHandler()
    {
        Repository = new ProduktRepository();
    }

    public List<Produkt> GetAll()
    {
        return Repository.GetAll();
    }

    public Produkt Create(string name, string note, PackingType packingType, Butik butik, double price, int grams, int calories)
    {
        var produkt = new Produkt{
            Name = name,
            Note = note,
            PackingType = packingType,
            Price = price,
            Grams = grams,
            Calories = calories,
            Butik = butik
        };

        produkt = Repository.Create(produkt);

        return produkt;
    }

    public void Delete(Produkt produkt)
    {
        Repository.Delete(produkt);
    }
}
