using Models;

namespace Repositories;

public class ProduktRepository : BaseRepository<Produkt>
{
    public List<Produkt> GetForCreate(List<int> existingIds, string search, int amount)
    {
        var produkter = DbContext.Produkter.Where(p => !existingIds.Contains(p.Id));

        if (!string.IsNullOrEmpty(search))
        {
            search = search.ToLower();
            
            produkter = produkter.Where(p => p.Name.ToLower().Contains(search) || p.Note.ToLower().Contains(search));
        }

        return produkter.Take(amount).ToList();
    }

    public List<Produkt> GetProdukterToUpdateTilbud(int amount)
    {
        DateTime today = DateTime.Today;

        var produkter = DbContext.Produkter
            .Where(p => p.Butik == Butik.Rema1000)
            .Where(p => p.Varenummer != null)
            .Where(p => (p.TilbudDataUpdatedAt == null) || (p.TilbudDataUpdatedAt.HasValue && p.TilbudDataUpdatedAt.Value.Date < today))
            .OrderBy(p => p.TilbudDataUpdatedAt)
            .Take(amount)
            .ToList();
        
        return produkter;
    }

    public List<Produkt> GetProdukterMedTilbud()
    {
        var produkter = DbContext.Produkter
            .Where(p => p.TilbudPrice != null)
            .ToList();
        
        return produkter;
    }
}
