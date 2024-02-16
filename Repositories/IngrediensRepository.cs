using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories;

public class IngrediensRepository : BaseRepository<Ingrediens>
{
    public void CreateRelation(Ingrediens ingrediens)
    {
        // Relation already exists, no need to add it again
        if (DbContext.Ingredienser.Any(i => i.RetId == ingrediens.RetId && i.ProduktId == ingrediens.ProduktId))
        {
            Console.WriteLine("Relation already exists");
            return;
        }

        DbContext.Ingredienser.Add(ingrediens);
        DbContext.SaveChanges();
    }

    public void DeleteRelation(Ingrediens ingrediens)
    {
        if (DbContext.Ingredienser.Any(i => i.RetId == ingrediens.RetId && i.ProduktId == ingrediens.ProduktId))
        {
            DbContext.Ingredienser.Remove(ingrediens);
            DbContext.SaveChanges();
        }
        else {
            Console.WriteLine("No relation found");
        }
    }

    public List<Ingrediens> GetByRetId(int retId)
    {
        return DbContext.Ingredienser
            .Where(i => i.RetId == retId)
            .Include(i => i.Produkt)
            .ToList();
    }
}
