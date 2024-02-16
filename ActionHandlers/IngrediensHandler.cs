using Models;
using Repositories;

namespace ActionHandlers;

public class IngrediensHandler
{
    private readonly IngrediensRepository Repository;

    public IngrediensHandler()
    {
        Repository = new IngrediensRepository();
    }

    public void Create(Ret ret, Produkt produkt, string note, int grams)
    {
        var ingrediens = new Ingrediens {
            RetId = ret.Id,
            ProduktId = produkt.Id,
            Note = note,
            Grams = grams
        };

        Repository.CreateRelation(ingrediens);
    }

    public void Remove(Ingrediens ingrediens)
    {
        Repository.DeleteRelation(ingrediens);
    }

    public List<Ingrediens> GetByRetId(int retId)
    {
        return Repository.GetByRetId(retId);
    }
}
