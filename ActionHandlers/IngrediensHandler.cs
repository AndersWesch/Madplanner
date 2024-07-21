using Models;
using Repositories;

namespace ActionHandlers;

public class IngrediensHandler
{
    private readonly IngrediensRepository _repository;

    public IngrediensHandler(IngrediensRepository repository)
    {
        _repository = repository;
    }

    public void Create(Ret ret, Produkt produkt, string? note, int grams)
    {
        var ingrediens = new Ingrediens {
            RetId = ret.Id,
            ProduktId = produkt.Id,
            Note = note,
            Grams = grams
        };

        _repository.CreateRelation(ingrediens);
    }

    public void Remove(Ingrediens ingrediens)
    {
        _repository.DeleteRelation(ingrediens);
    }

    public List<Ingrediens> GetByRetId(int retId)
    {
        return _repository.GetByRetId(retId);
    }
}
