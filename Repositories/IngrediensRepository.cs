using Database;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories;

public class IngrediensRepository : BaseRepository<Ingrediens>
{
    public IngrediensRepository(DatabaseContext dbContext) : base(dbContext)
    {
    }

    public void CreateRelation(Ingrediens ingrediens)
    {
        // Relation already exists, no need to add it again
        if (_databaseContext.Ingredienser.Any(i => i.RetId == ingrediens.RetId && i.ProduktId == ingrediens.ProduktId))
        {
            Console.WriteLine("Relation already exists");
            return;
        }

        _databaseContext.Ingredienser.Add(ingrediens);
        _databaseContext.SaveChanges();
    }

    public void DeleteRelation(Ingrediens ingrediens)
    {
        if (_databaseContext.Ingredienser.Any(i => i.RetId == ingrediens.RetId && i.ProduktId == ingrediens.ProduktId))
        {
            _databaseContext.Ingredienser.Remove(ingrediens);
            _databaseContext.SaveChanges();
        }
        else {
            Console.WriteLine("No relation found");
        }
    }

    public List<Ingrediens> GetByRetId(int retId)
    {
        return _databaseContext.Ingredienser
            .Where(i => i.RetId == retId)
            .Include(i => i.Produkt)
            .ToList();
    }
}
