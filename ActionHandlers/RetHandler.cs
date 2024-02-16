using Models;
using Repositories;

namespace ActionHandlers;

public class RetHandler
{
    private readonly RetRepository Repository;
    private readonly IngrediensRepository ingrediensRepository;

    public RetHandler()
    {
        Repository = new RetRepository();
        ingrediensRepository = new IngrediensRepository();
    }

    public List<Ret> GetAll()
    {
        return Repository.GetAll();
    }

    public Ret GetById(int id)
    {
        return Repository.GetById(id);
    }

    public Ret Update(Ret ret)
    {
        return Repository.Update(ret);
    }

    public Ret Create(string name, string description, Category category, bool vegetarian, bool porkBased, bool leftovers, bool takeaway)
    {
        var ret = new Ret{
            Name = name,
            Description = description,
            Category = category,
            Vegetarian = vegetarian,
            PorkBased = porkBased,
            Leftovers = leftovers,
            Takeaway = takeaway
        };

        ret = Repository.Create(ret);

        return ret;
    }

    public void Delete(Ret ret)
    {
        Repository.Delete(ret);
    }
}
