using Database;
using Models;

namespace Seeders;

public class IngrediensSeeder : ISeeder<Ingrediens>
{    
    public List<Ingrediens> Seed()
    {
        //var DbContext = new DatabaseContext();
        //var bolognese = DbContext.Retter.Where(r => r.Name == "Pasta Bolognese").FirstOrDefault();

        return new List<Ingrediens>{
            //new Ingrediens {
            //    RetId = bolognese.Id,
            //    ProduktId = 7,
            //    Grams = 200
            //}
        };

        /**
        return new List<Ingrediens> {
            new Ingrediens {
                RetId = bolognese.Id,
                ProduktId = DbContext.Produkter.Where(p => p.Name == "Hakkede tomater").FirstOrDefault().Id,
                Grams = 400
            },
            new Ingrediens {
                RetId = bolognese.Id,
                ProduktId = DbContext.Produkter.Where(p => p.Name == "Hakket oksekød").FirstOrDefault().Id,
                Grams = 400
            },
            new Ingrediens {
                RetId = bolognese.Id,
                ProduktId = DbContext.Produkter.Where(p => p.Name == "Løg").FirstOrDefault().Id,
                Grams = 150
            },
            new Ingrediens {
                RetId = bolognese.Id,
                ProduktId = DbContext.Produkter.Where(p => p.Name == "Pasta").FirstOrDefault().Id,
                Grams = 250
            },
            new Ingrediens {
                RetId = bolognese.Id,
                ProduktId = DbContext.Produkter.Where(p => p.Name == "Tomat Pasta").FirstOrDefault().Id,
                Grams = 140
            }
        };
        **/
    }
}