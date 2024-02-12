using Database;
using Models;
using Seeders;

namespace Repositories;

public class ProduktRepository
{
    private readonly DatabaseContext DbContext;

    public ProduktRepository()
    {
        DbContext = new DatabaseContext();

        //Seed();
    }

    public Produkt Create(Produkt produkt)
    {
        DbContext.Produkter.Add(produkt);
        DbContext.SaveChanges();

        return produkt;
    }

    public List<Produkt> GetAll()
    {
        return DbContext.Produkter.ToList();
    } 

    public void Delete(Produkt produkt)
    {
        DbContext.Produkter.Remove(produkt);
        DbContext.SaveChanges();
    }

    private void Seed()
    {
        var produktSeeder = new ProduktSeeder();
        var produkter = produktSeeder.Seed();

        foreach (var produkt in produkter) 
        {
            Create(produkt);
        }
    }
}
