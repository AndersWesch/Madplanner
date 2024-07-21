using Models;
using Repositories;

namespace ActionHandlers;

public class RetHandler
{
    private readonly RetRepository _retRepository;

    public RetHandler(RetRepository retRepository)
    {
        _retRepository = retRepository;
    }

    public List<Ret> GetAll()
    {        
        return _retRepository.GetAll();
    }

    public Ret GetById(int id)
    {
        return _retRepository.GetById(id);
    }

    public Ret Update(Ret ret)
    {
        return _retRepository.Update(ret);
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

        ret = _retRepository.Create(ret);

        return ret;
    }

    public void Delete(Ret ret)
    {
        _retRepository.Delete(ret);
    }
}
