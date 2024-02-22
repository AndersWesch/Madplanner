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
                Butik = Butik.Rema1000,
                Varenummer = 108334,
            },
            new Produkt {
                Name = "Kidney bønner i chilisauce",
                PackingType = PackingType.Dåse,
                Price = 7.95,
                Grams = 410,
                Calories = 100,
                Butik = Butik.Rema1000,
                Varenummer = 107912,
            },
            new Produkt {
                Name = "Kikærter Økologisk",
                PackingType = PackingType.Dåse,
                Price = 7.5,
                Grams = 400,
                Calories = 117,
                Butik = Butik.Rema1000,
                Varenummer = 100042,
            },
            new Produkt {
                Name = "Tomat Pasta",
                Note = "Tomat Purre",
                PackingType = PackingType.Dåse,
                Price = 4.95,
                Grams = 140,
                Calories = 86,
                Butik = Butik.Rema1000,
                Varenummer = 111408,
            },
            new Produkt {
                Name = "Kokosmælk",
                PackingType = PackingType.Dåse,
                Price = 7.75,
                Grams = 400,
                Calories = 162,
                Butik = Butik.Rema1000,
                Varenummer = 120171,
            },
            new Produkt {
                Name = "Majs",
                PackingType = PackingType.Dåse,
                Price = 7.50,
                Grams = 300,
                Calories = 79,
                Butik = Butik.Rema1000,
                Varenummer = 100425,
            },
            new Produkt {
                Name = "Aspargessnitter",
                PackingType = PackingType.Dåse,
                Price = 12.95,
                Grams = 430,
                Calories = 11,
                Butik = Butik.Rema1000,
                Varenummer = 100166,
            },
            
            new Produkt {
                Name = "Salsa Medium",
                Note = "Tex Mex Salsasauce Medium",
                PackingType = PackingType.Glas,
                Price = 9.75,
                Grams = 315,
                Calories = 53,
                Butik = Butik.Rema1000,
                Varenummer = 102810,
            },

            new Produkt {
                Name = "Tortillas",
                Note = "Tex Mex Fuldkorns Tortillas",
                PackingType = PackingType.Pose,
                Price = 12.25,
                Grams = 370,
                Calories = 299,
                Butik = Butik.Rema1000,
                Varenummer = 102831,
            },

            new Produkt {
                Name = "Rød Karrypasta",
                PackingType = PackingType.Glas,
                Price = 10.95,
                Grams = 110,
                Calories = 222,
                Butik = Butik.Rema1000,
                Varenummer = 100831,
            },

            // Pose 
            new Produkt {
                Name = "Ris",
                Note = "Jasmin ris",
                PackingType = PackingType.Pose,
                Price = 14.95,
                Grams = 1000,
                Calories = 357,
                Butik = Butik.Rema1000,
                Varenummer = 98164,
            },

            new Produkt {
                Name = "Pasta",
                Note = "Fusilli Fuldkorn Økologisk",
                PackingType = PackingType.Pose,
                Price = 11.95,
                Grams = 500,
                Calories = 350,
                Butik = Butik.Rema1000,
                Varenummer = 90330,
            },

            new Produkt {
                Name = "Suppehorn",
                Note = "Pasta horn",
                PackingType = PackingType.Pose,
                Price = 9.5,
                Grams = 500,
                Calories = 347,
                Butik = Butik.Rema1000,
                SeedKey = "suppehorn",
                Varenummer = 90814,
            },

            new Produkt {
                Name = "Spaghetti",
                Note = "Økologisk Fuldkorns Spaghetti Pasta",
                PackingType = PackingType.Pose,
                Price = 8.95,
                Grams = 500,
                Calories = 350,
                Butik = Butik.Rema1000,
                Varenummer = 90335,
            },

            new Produkt {
                Name = "Tortiglioni",
                Note = "De Cecco - gode pasta",
                PackingType = PackingType.Pose,
                Price = 21.5,
                Grams = 500,
                Calories = 351,
                Butik = Butik.Lovbjerg
            },

            new Produkt {
                Name = "Tortellini",
                Note = "Ricotta og spinat (TODO tjek kcal og pris)",
                PackingType = PackingType.Karton,
                Price = 24.95,
                Grams = 500,
                Calories = 400,
                Butik = Butik.Coop365
            },

            new Produkt {
                Name = "Lasagneplader",
                Note = "Fuldkorns lasagneplader",
                PackingType = PackingType.Pakke,
                Price = 16.95,
                Grams = 500,
                Calories = 338,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Bucatini",
                Note = "Makaroni Pasta",
                PackingType = PackingType.Pose,
                Price = 9.95,
                Grams = 500,
                Calories = 347,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Mornaysauce",
                Note = "Bechamel / oste sauce",
                PackingType = PackingType.Karton,
                Price = 17.95,
                Grams = 500,
                Calories = 140,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Tomatsuppe",
                Note = "Karolines Køkken Tomatsuppe",
                PackingType = PackingType.Karton,
                Price = 30.95,
                Grams = 1000,
                Calories = 50,
                Butik = Butik.Rema1000,
                SeedKey = "karoline-tomat"
            },

            new Produkt {
                Name = "Pitabrød",
                Note = "Fuldkorns pitabrød (TODO tjek kcal)",
                PackingType = PackingType.Pose,
                Price = 5.95,
                Grams = 320,
                Calories = 237,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Røde Linser",
                Note = "Røde Split Linser",
                PackingType = PackingType.Pose,
                Price = 16.95,
                Grams = 400,
                Calories = 346,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Tartelet skaller",
                Note = "Humlum Luxus tarteletter",
                PackingType = PackingType.Pose,
                Price = 14.75,
                Grams = 225,
                Calories = 570,
                Butik = Butik.Rema1000
            },
            
            new Produkt {
                Name = "Burgerboller",
                Note = "Fuldkorns burgerboller",
                PackingType = PackingType.Pose,
                Price = 20.5,
                Grams = 320,
                Calories = 260,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Nudler",
                Note = "Egg noodles",
                PackingType = PackingType.Pose,
                Price = 6.95,
                Grams = 250,
                Calories = 364,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Falafel",
                Note = "Urtekram falafler",
                PackingType = PackingType.Pose,
                Price = 59.95,
                Grams = 500,
                Calories = 321,
                Butik = Butik.Lovbjerg
            },

            new Produkt {
                Name = "Wok blanding",
                Note = "Wok blanding fra frost",
                PackingType = PackingType.Pose,
                Price = 13.95,
                Grams = 400,
                Calories = 37,
                Butik = Butik.Rema1000
            },
            
            new Produkt {
                Name = "Blomkålsris",
                Note = "Økologiske Blomkålsris fra frost",
                PackingType = PackingType.Pose,
                Price = 13.95,
                Grams = 350,
                Calories = 28,
                Butik = Butik.Rema1000
            },

            // Pakke
            new Produkt {
                Name = "Hakket oksekød",
                Note = "8%-12%",
                PackingType = PackingType.Pakke,
                Price = 44.95,
                Grams = 500,
                Calories = 172,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Hakket grisekød",
                Note = "8%-12%",
                PackingType = PackingType.Pakke,
                Price = 36.95,
                Grams = 400,
                Calories = 168,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Hakket kyllingekød",
                Note = "7%-10%",
                PackingType = PackingType.Pakke,
                Price = 34.95,
                Grams = 400,
                Calories = 155,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Kyllingebrystfilet",
                Note = "Karolines Madlavningsfløde 8%",
                PackingType = PackingType.Pakke,
                Price = 34.95,
                Grams = 280,
                Calories = 95,
                Butik = Butik.Rema1000
            },
            
            new Produkt {
                Name = "Madlavningsfløde",
                Note = "Karolines Madlavningsfløde 8%",
                PackingType = PackingType.Karton,
                Price = 12.75,
                Grams = 250,
                Calories = 115,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Pizzabund",
                Note = "Surdejs pizzabund",
                PackingType = PackingType.Pose,
                Price = 19.95,
                Grams = 200,
                Calories = 249,
                Butik = Butik.Netto
            },

            new Produkt {
                Name = "Mascarpone",
                PackingType = PackingType.Pakke,
                Price = 19.95,
                Grams = 250,
                Calories = 411,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Mozarella",
                Note = "Mozarella ost i blok",
                PackingType = PackingType.Pose,
                Price = 8.5,
                Grams = 125,
                Calories = 251,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Grana Padano",
                Note = "Paramsan ost i blok",
                PackingType = PackingType.Pakke,
                Price = 33.95,
                Grams = 200,
                Calories = 398,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Serano skinke",
                Note = "Hola! Spansk Serano",
                PackingType = PackingType.Pakke,
                Price = 12.95,
                Grams = 60,
                Calories = 232,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Æg",
                Note = "Skrabeæg",
                PackingType = PackingType.Pakke,
                Price = 24.85,
                Grams = 350,
                Calories = 141,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Salciccia",
                Note = "Italiensk pølse",
                PackingType = PackingType.Pakke,
                Price = 49.95,
                Grams = 200,
                Calories = 258,
                Butik = Butik.Lovbjerg
            },

            new Produkt {
                Name = "Minimælk",
                Note = "0,4% Fedt",
                PackingType = PackingType.Karton,
                Price = 10.95,
                Grams = 1000,
                Calories = 36,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Pesto",
                Note = "Rød Pesto",
                PackingType = PackingType.Glas,
                Price = 6.80,
                Grams = 130,
                Calories = 410,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Pesto",
                Note = "Grøn Pesto",
                PackingType = PackingType.Glas,
                Price = 6.80,
                Grams = 130,
                Calories = 410,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Pesto",
                Note = "Grøn Pesto med Basilikum",
                PackingType = PackingType.Pakke,
                Price = 16.95,
                Grams = 130,
                Calories = 497,
                Butik = Butik.Rema1000
            },

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

            new Produkt {
                Name = "Kartofler",
                Note = "Økologisk",
                PackingType = PackingType.Pose,
                Price = 12.00,
                Grams = 1000,
                Calories = 82,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Spidskål",
                Note = "Økologisk",
                PackingType = PackingType.Stk,
                Price = 16.00,
                Grams = 1000,
                Calories = 27,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Agruk",
                Note = "Økologisk",
                PackingType = PackingType.Stk,
                Price = 9.00,
                Grams = 300,
                Calories = 11,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Tomater",
                Note = "Økologisk",
                PackingType = PackingType.Pakke,
                Price = 19.00,
                Grams = 400,
                Calories = 20,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Avocado",
                Note = "Modne Avocadoer - Guacamole",
                PackingType = PackingType.Pakke,
                Price = 16.50,
                Grams = 300,
                Calories = 160,
                Butik = Butik.Rema1000
            },

            new Produkt {
                Name = "Spinat",
                Note = "Frisk baby spinat",
                PackingType = PackingType.Pose,
                Price = 12.00,
                Grams = 1000,
                Calories = 82,
                Butik = Butik.Rema1000
            },
        };
    }
}
