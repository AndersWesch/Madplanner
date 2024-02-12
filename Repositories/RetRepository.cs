using Database;
using Models;
using Seeders;

namespace Repositories;

public class RetRepository
{
    private readonly DatabaseContext DbContext;

    public RetRepository()
    {
        DbContext = new DatabaseContext();

        //Seed();   
    }

    public Ret Create(Ret ret)
    {
        DbContext.Retter.Add(ret);
        DbContext.SaveChanges();
        
        return ret;
    }

    public void Delete(Ret ret)
    {
        DbContext.Retter.Remove(ret);
        DbContext.SaveChanges();
    }

    public List<Ret> GetAll()
    {
        return DbContext.Retter.ToList();
    } 

    public Ret GetRandomRet()
    {
        // Fetch all Retter entities into memory
        var allRetter = DbContext.Retter.ToList();

        // Get a random index within the range of available Retter entities
        var randomIndex = new Random().Next(0, allRetter.Count);

        // Return the randomly selected Ret entity
        return allRetter[randomIndex];
    }

    private void Seed()
    {
        var retSeeder = new RetSeeder();
        var retter = retSeeder.Seed();

        foreach (var ret in retter) 
        {
            Create(ret);
        }
    }
}
