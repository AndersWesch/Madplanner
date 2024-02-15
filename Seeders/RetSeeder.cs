using Models;

namespace Seeders;

public class RetSeeder : ISeeder<Ret>
{
    public List<Ret> Seed()
    {
        // Ana frugt og grønt
        // Røvernes pita
        // Wrap med falafel

        return new List<Ret> {
            // Suppe
            new Ret {
                Name = "Tomatsuppe",
                Description = "Tomatsuppe på røde linser",
                Category = Category.Suppe,
                Vegetarian = true,
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
                PorkBased = true
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
                Leftovers = true
            },
            new Ret {
                Name = "Blomkålsrisotto",
                Description = "En risotto på blomkålsris",
                Category = Category.Italiensk,
            },

            // Mexikansk
            new Ret {
                Name = "Tortillas",
                Description = "Tortillas pandekager med diverse",
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
                Category = Category.Asiatisk
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
                Category = Category.Sandwich
            },

            // Salat
            new Ret {
                Name = "Tortelini salat",
                Description = "Salat med tortelini og spinat",
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

            // Dansk
            new Ret {
                Name = "Tærte",
                Description = "Tærte med skinke og spinat",
                Category = Category.Dansk
            },
            new Ret {
                Name = "Biksemad",
                Description = "Alt godt stegt på en pande",
                Category = Category.Dansk
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
            }
        };
    }
}
