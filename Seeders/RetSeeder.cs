using Models;

namespace Seeders;

public class RetSeeder : ISeeder<Ret>
{
    public List<Ret> Seed()
    {
        // Minestronesuppe
        // Karry suppe
        // Retter på grillen
        // Kyllingelår med rodfrugter i ovnen

        return new List<Ret> {
            // Suppe
            new Ret {
                Name = "Tomatsuppe",
                Description = "Tomatsuppe på røde linser",
                Category = Category.Suppe,
                Vegetarian = true,
            },

            new Ret {
                Name = "Tomatsuppe",
                Description = "Tomatsuppe fra Karolines Køkken",
                Category = Category.Suppe,
                Vegetarian = true,
                SeedKey = "tomatsuppe"
            },

            new Ret {
                Name = "Kartoffel porre suppe",
                Description = "Grøntsagssuppe god med bacon",
                Category = Category.Suppe,
                Vegetarian = true,
            },
            new Ret {
                Name = "Jordskokkesuppe",
                Description = "Efterårssuppe",
                Category = Category.Suppe,
                Vegetarian = true,
            },
            new Ret {
                Name = "Hønsekødsuppe",
                Description = "En klassisk suppe",
                Category = Category.Suppe,
            },

            // Italiensk
            new Ret {
                Name = "Rød Pasta",
                Description = "Rød Pasta med salcicia og rosmarin",
                Category = Category.Italiensk,
                PorkBased = true,
                SeedKey = "rodpasta"
            },
            new Ret {
                Name = "La Carbonara ",
                Description = "Enkel og lækker pastaret",
                Category = Category.Italiensk,
                PorkBased = true
            },
            new Ret {
                Name = "Pasta Bolognese",
                Description = "Klassisk pasta og kødsovs",
                Category = Category.Italiensk,
                Leftovers = true,
                SeedKey = "pasta-kodsovs"
            },
            new Ret {
                Name = "Beluga Bolognese",
                Description = "Kødsovs med beluga",
                Category = Category.Italiensk,
                Leftovers = true
            },
            new Ret {
                Name = "Annes pasta",
                Description = "Annes helt egen opskrift på en cremet pasta",
                Category = Category.Italiensk,
                PorkBased = true
            },
            new Ret {
                Name = "Kartoffelpizza",
                Description = "Nem pizza med bund fra Netto",
                Category = Category.Italiensk,
                Vegetarian = true
            },
            new Ret {
                Name = "Lasagne",
                Description = "En italiensk klassiker alle elsker",
                Category = Category.Italiensk,
                Leftovers = true,
                SeedKey = "lasagne"
            },
            new Ret {
                Name = "Blomkålsrisotto",
                Description = "En risotto på blomkålsris",
                Category = Category.Italiensk,
            },

            // Mexikansk
            new Ret {
                Name = "Tortillas med kylling",
                Description = "Tortillas pandekager (wrap) med diverse",
                Category = Category.Mexikansk
            },
            new Ret {
                Name = "Tortillas med falafel",
                Description = "Tortillas pandekager (wrap) med diverse",
                Category = Category.Mexikansk
            },
            new Ret {
                Name = "Tortillas med okse",
                Description = "Tortillas pandekager (wrap) med diverse",
                Category = Category.Mexikansk
            },
            new Ret {
                Name = "Quesadilla",
                Description = "Stegte Tortillas pandekager med ost",
                Category = Category.Mexikansk
            },

            // Asiatisk 
            new Ret {
                Name = "Rød Karry",
                Description = "Rød karry baseret på karry pasta og kokosmælk",
                Category = Category.Asiatisk
            },   
            new Ret {
                Name = "Grøn Karry",
                Description = "Grøn karry wok med kokosmælk",
                Category = Category.Asiatisk
            }, 
            new Ret {
                Name = "Panang Karry",
                Description = "Panang karry med kylling og grøntsager",
                Category = Category.Asiatisk,
                SeedKey = "panang"
            },    
            new Ret {
                Name = "Vietnamesiske forårsruller ",
                Description = "Friske forårsruller med lækre sager i",
                Category = Category.Asiatisk
            },       

            // Sandwich
            new Ret {
                Name = "Åses Sandwich",
                Description = "Hurtigt, nemt og lækkert",
                Category = Category.Sandwich,
                SeedKey = "aase"
            },

            // Salat
            new Ret {
                Name = "Tortellini salat",
                Description = "Salat med tortellini og spinat",
                Category = Category.Salat
            },
            new Ret {
                Name = "Quinoa salat",
                Description = "Salat med quinoa og grøntsager",
                Category = Category.Salat
            },
            new Ret {
                Name = "Pasta salat",
                Description = "Pasta salat med kylling",
                Category = Category.Salat
            },
            new Ret {
                Name = "Cous Cous salat",
                Description = "Cous Cous salat med diverse grøntsager",
                Category = Category.Salat
            },

            // Andet
            new Ret {
                Name = "Pitabrød med Kylling",
                Description = "Simpelt pitabrød med kylling og diverse grønt",
                Category = Category.Andet
            },

            new Ret {
                Name = "Tortellini og pølser",
                Description = "Børnefavorit",
                Category = Category.Salat
            },

            // Dansk
            new Ret {
                Name = "Tærte",
                Description = "Tærte med skinke og spinat",
                Category = Category.Dansk,
                SeedKey = "taerte"
            },
            new Ret {
                Name = "Biksemad",
                Description = "Alt godt stegt på en pande",
                Category = Category.Dansk,
                SeedKey = "biksemad"
            },
            new Ret {
                Name = "Tarteletter",
                Description = "Høns i asparges",
                Category = Category.Dansk
            },
            new Ret {
                Name = "Boller i karry",
                Description = "En rigtig børn ret",
                Category = Category.Dansk,
                PorkBased = true
            },
            new Ret {
                Name = "Hotdogs",
                Description = "Et par hotdogs med det hele",
                Category = Category.Dansk,
                PorkBased = true
            },
            new Ret {
                Name = "Frikadeller",
                Description = "Frikadeller med rodfrugter eller pasta",
                Category = Category.Dansk,
                PorkBased = true
            },

            // Indisk
            new Ret {
                Name = "Butter Chicken",
                Description = "Indisk klassiker",
                Category = Category.Indisk,
                Leftovers = true
            },
            new Ret {
                Name = "Chicken Masala",
                Description = "Indisk klassiker",
                Category = Category.Indisk,
                Leftovers = true
            },
            new Ret {
                Name = "Dhal",
                Description = "Dhal, ris og naan",
                Category = Category.Indisk,
                Leftovers = true,
                Vegetarian = true,
            },

            // Spansk
            new Ret {
                Name = "Kartoffeltærte",
                Description = "Kartofler og æg så vidt jeg husker",
                Category = Category.Spansk
            },

            // Amerikansk
            new Ret {
                Name = "Burger",
                Description = "Burger og fritter",
                Category = Category.Amerikansk
            },

            // Takeaway
            new Ret {
                Name = "Ana",
                Description = "Frugt og Grønt",
                Category = Category.Salat,
                Vegetarian = true,
                Takeaway = true,
                SeedKey = "ana"
            },

            new Ret {
                Name = "De Fyrretyve Røvere",
                Description = "Pitabrød",
                Category = Category.Andet,
                Takeaway = true,
            }
        };
    }
}
