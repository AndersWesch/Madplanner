using Models;

namespace Repositories;

public class ProduktRepository : BaseRepository<Produkt>
{
    public List<Produkt> GetForCreate(List<int> existingIds, string search)
    {
        var produkter = DbContext.Produkter.Where(p => !existingIds.Contains(p.Id));

        if (!string.IsNullOrEmpty(search))
        {
            search = search.ToLower();
            
            produkter = produkter.Where(p => p.Name.ToLower().Contains(search) || p.Note.ToLower().Contains(search));
        }

        return produkter.ToList();
    }
}
