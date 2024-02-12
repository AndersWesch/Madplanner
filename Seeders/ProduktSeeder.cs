using Models;

namespace Seeders;

public class ProduktSeeder : ISeeder<Produkt>
{
    public List<Produkt> Seed()
    {
        return new List<Produkt> {
            // Dåser
            new Produkt {
                Name = "Hakkede tomater",
                Note = "Med basilikum og oregano",
                PackingType = PackingType.Dåse,
                Price = 7.5,
                Grams = 400,
                Calories = 24,
                Butik = Butik.Rema1000
            },
            new Produkt {
                Name = "Kidney bønner i chilisauce",
                PackingType = PackingType.Dåse,
                Price = 7.95,
                Grams = 410,
                Calories = 100,
                Butik = Butik.Rema1000
            },
            new Produkt {
                Name = "Kikærter Økologisk",
                PackingType = PackingType.Dåse,
                Price = 7.5,
                Grams = 400,
                Calories = 117,
                Butik = Butik.Rema1000
            },
            new Produkt {
                Name = "Tomat Pasta",
                Note = "Tomat Purre",
                PackingType = PackingType.Dåse,
                Price = 4.95,
                Grams = 140,
                Calories = 86,
                Butik = Butik.Rema1000
            },
            new Produkt {
                Name = "Kokosmælk",
                PackingType = PackingType.Dåse,
                Price = 7.75,
                Grams = 400,
                Calories = 162,
                Butik = Butik.Rema1000
            },

            // Majs

            // Asparges

            // Glas
            new Produkt {
                Name = "Salsa Medium",
                Note = "Tex Mex Salsasauce Medium",
                PackingType = PackingType.Glas,
                Price = 9.75,
                Grams = 315,
                Calories = 53,
                Butik = Butik.Rema1000
            },

            // Karrry pasta

            // Pose 
            new Produkt {
                Name = "Ris",
                Note = "Jasmin ris",
                PackingType = PackingType.Pose,
                Price = 14.95,
                Grams = 1000,
                Calories = 357,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Pasta",
                Note = "Fusilli Fuldkorn Økologisk",
                PackingType = PackingType.Pose,
                Price = 11.95,
                Grams = 500,
                Calories = 350,
                Butik = Butik.Rema1000
            },

            // Gode pasta

            // Tortelini

            // Lasagne plader

            // Bechamel

            // Pitabrød

            // Røde linser

            // Tartelet skaller

            // Burger boller

            // Nudler

            // Frost wok blanding

            // Frost blomkålsris

            // Pakke
            new Produkt {
                Name = "Hakket oksekød 8%-12%",
                PackingType = PackingType.Pakke,
                Price = 44.95,
                Grams = 500,
                Calories = 172,
                Butik = Butik.Rema1000
            },

            // Hakket gris

            // Kyllinge bryst

            // Madlavningsfløde

            // Tortilla

            // Pizza bund

            // Mascarpone

            // Mozarella

            // Serano

            // Æg

            // Mælk

            // Pesto

            // Grøntsager
            new Produkt {
                Name = "Løg",
                Note = "Økologisk",
                PackingType = PackingType.Pose,
                Price = 11.00,
                Grams = 750,
                Calories = 40,
                Butik = Butik.Rema1000
            },
            new Produkt {
                Name = "Rødløg",
                Note = "Økologisk",
                PackingType = PackingType.Pose,
                Price = 12.00,
                Grams = 500,
                Calories = 44,
                Butik = Butik.Rema1000
            },
            new Produkt {
                Name = "Gulerødder",
                Note = "Økologisk",
                PackingType = PackingType.Pose,
                Price = 14.00,
                Grams = 1000,
                Calories = 41,
                Butik = Butik.Rema1000
            },

            // Kartofler

            // Spidskål

            // Agurk 

            // Tomater

            // Avocado

            // Spinat
        };
    }
}
