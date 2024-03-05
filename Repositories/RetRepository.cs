using System.Linq;
using Microsoft.EntityFrameworkCore;
using Models;
using Seeders;

namespace Repositories;

public class RetRepository : BaseRepository<Ret>
{
    public Ret GetRandomRet(List<Ret>? excludeRetter)
    {
        var excludeIds = excludeRetter.Select(r => r.Id).ToList();

        // Fetch all Retter entities into memory
        var allRetter = DbContext.Retter
                        .Where(r => !excludeIds.Contains(r.Id))
                        .ToList();

        // Get a random index within the range of available Retter entities
        var randomIndex = new Random().Next(0, allRetter.Count);

        // Return the randomly selected Ret entity
        return allRetter[randomIndex];
    }

    public Ret GetWithIngredienser(int id)
    {
        var ret = DbContext.Retter
            .Include(r => r.Ingredienser)
            .ThenInclude(i => i.Produkt)
            .FirstOrDefault(r => r.Id == id);
        
        if (ret == null)
        {
            throw new Exception("Could not find Ret with id: " + id);
        }

        return ret;
    }
}
