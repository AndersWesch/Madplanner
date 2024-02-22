using Database;
using Models;

namespace Seeders;

public class IngrediensSeeder : ISeeder<Ingrediens>
{    
    public List<Ingrediens> Seed()
    {
        var DbContext = new DatabaseContext();

        // Retter
        var tomatsuppe = DbContext.Retter.Where(r => r.SeedKey == "tomatsuppe").FirstOrDefault();
        var rodpasta = DbContext.Retter.Where(r => r.SeedKey == "rodpasta").FirstOrDefault();

        // Produkter
        var karolinetomatsuppe = DbContext.Produkter.Where(r => r.SeedKey == "karoline-tomat").FirstOrDefault();
        var suppehorn = DbContext.Produkter.Where(r => r.SeedKey == "suppehorn").FirstOrDefault();
        
        return new List<Ingrediens>{
            // Tomatsuppe
            new Ingrediens {
                RetId = tomatsuppe.Id,
                ProduktId = karolinetomatsuppe.Id,
                Grams = karolinetomatsuppe.Grams
            },
            new Ingrediens {
                RetId = tomatsuppe.Id,
                ProduktId = suppehorn.Id,
                Grams = 250
            },

            // 
        };
    }
}