using Database;
using Microsoft.VisualBasic;
using Models;

namespace Seeders;

public class IngrediensSeeder : ISeeder<Ingrediens>
{    
    public List<Ingrediens> Seed()
    {
        var DbContext = new DatabaseContext();

        // Retter
        var tomatsuppe = DbContext.Retter.Where(r => r.SeedKey == "tomatsuppe").FirstOrDefault();
        // var rodpasta = DbContext.Retter.Where(r => r.SeedKey == "rodpasta").FirstOrDefault();
        var lasagne = DbContext.Retter.Where(r => r.SeedKey == "lasagne").FirstOrDefault();
        var pastaKodsovs = DbContext.Retter.Where(r => r.SeedKey == "pasta-kodsovs").FirstOrDefault();
        var aasesSandwich = DbContext.Retter.Where(r => r.SeedKey == "aase").FirstOrDefault();
        var ana = DbContext.Retter.Where(r => r.SeedKey == "ana").FirstOrDefault();
        var panang = DbContext.Retter.Where(r => r.SeedKey == "panang").FirstOrDefault();
        var biksemad = DbContext.Retter.Where(r => r.SeedKey == "biksemad").FirstOrDefault();
        var taerte = DbContext.Retter.Where(r => r.SeedKey == "taerte").FirstOrDefault();
        var pastaSalat = DbContext.Retter.Where(r => r.SeedKey == "pasta-salat").FirstOrDefault();
        var rodKarry = DbContext.Retter.Where(r => r.SeedKey == "rod-karry").First();
        var tortillasOkse = DbContext.Retter.Where(r => r.SeedKey == "tortillas-okse").First();
        
        // Produkter
        var karolinetomatsuppe = DbContext.Produkter.Where(r => r.SeedKey == "karoline-tomat").FirstOrDefault();
        var suppehorn = DbContext.Produkter.Where(r => r.SeedKey == "suppehorn").FirstOrDefault();
        var log = DbContext.Produkter.Where(r => r.SeedKey == "log").FirstOrDefault();
        var hakkedeTomater = DbContext.Produkter.Where(r => r.SeedKey == "hakkede-tomater").FirstOrDefault();
        var tomatPurre = DbContext.Produkter.Where(r => r.SeedKey == "tomat-purre").FirstOrDefault();
        var hakketOkse = DbContext.Produkter.Where(r => r.SeedKey == "hakket-okse").FirstOrDefault();
        var lasagnePlader = DbContext.Produkter.Where(r => r.SeedKey == "lasagne-plader").FirstOrDefault();
        var bechamel = DbContext.Produkter.Where(r => r.SeedKey == "bechamel").FirstOrDefault();
        var mozarellaBlok = DbContext.Produkter.Where(r => r.SeedKey == "mozarella-blok").FirstOrDefault();
        var gulerodder = DbContext.Produkter.Where(r => r.SeedKey == "gulerodder").FirstOrDefault();
        var pita = DbContext.Produkter.Where(r => r.SeedKey == "pita").FirstOrDefault();
        var spidskaal = DbContext.Produkter.Where(r => r.SeedKey == "spidskaal").FirstOrDefault();
        var tomater = DbContext.Produkter.Where(r => r.SeedKey == "tomater").FirstOrDefault();
        var agurk = DbContext.Produkter.Where(r => r.SeedKey == "agurk").FirstOrDefault();
        var serano = DbContext.Produkter.Where(r => r.SeedKey == "serano").FirstOrDefault();
        var billigPesto = DbContext.Produkter.Where(r => r.SeedKey == "billig-pesto").FirstOrDefault();
        var samosa = DbContext.Produkter.Where(r => r.SeedKey == "samosa").FirstOrDefault();
        var storSalat = DbContext.Produkter.Where(r => r.SeedKey == "stor-salat").FirstOrDefault();
        var kokos = DbContext.Produkter.Where(r => r.SeedKey == "kokos").FirstOrDefault();
        var wokBlanding = DbContext.Produkter.Where(r => r.SeedKey == "wok-blanding").FirstOrDefault();
        var ris = DbContext.Produkter.Where(r => r.SeedKey == "ris").FirstOrDefault();
        var polse = DbContext.Produkter.Where(r => r.SeedKey == "polse").FirstOrDefault();
        var kartofel = DbContext.Produkter.Where(r => r.SeedKey == "kartofel").FirstOrDefault();
        var egg = DbContext.Produkter.Where(r => r.SeedKey == "egg").FirstOrDefault();
        var taertedej = DbContext.Produkter.Where(r => r.SeedKey == "taertedej").FirstOrDefault();
        var hytteost = DbContext.Produkter.Where(r => r.SeedKey == "hytteost").FirstOrDefault();
        var spinat = DbContext.Produkter.Where(r => r.SeedKey == "spinat").FirstOrDefault();
        var champignon = DbContext.Produkter.Where(r => r.SeedKey == "champignon").FirstOrDefault();
        var skinkeStrimler = DbContext.Produkter.Where(r => r.SeedKey == "skinke-strimler").FirstOrDefault();
        var milk = DbContext.Produkter.Where(r => r.SeedKey == "milk").FirstOrDefault();
        var revetOst = DbContext.Produkter.Where(r => r.SeedKey == "revet-ost").FirstOrDefault();
        var fusilli = DbContext.Produkter.Where(r => r.SeedKey == "fusilli").First();
        var edermame = DbContext.Produkter.Where(r => r.SeedKey == "edermame").First();

        return new List<Ingrediens>{
            // Tortilla okse
            new Ingrediens {
                RetId = tortillasOkse.Id,
                ProduktId = spidskaal.Id,
                Grams = 150,
            },
            new Ingrediens {
                RetId = tortillasOkse.Id,
                ProduktId = hakketOkse.Id,
                Grams = hakketOkse.Grams,
            },
            new Ingrediens {
                RetId = tortillasOkse.Id,
                ProduktId = tomater.Id,
                Grams = 200,
            },
            new Ingrediens {
                RetId = tortillasOkse.Id,
                ProduktId = agurk.Id,
                Grams = 150,
            },

            // Rød Karry
            new Ingrediens {
                RetId = rodKarry.Id,
                ProduktId = ris.Id,
                Grams = 300,
            },
            new Ingrediens {
                RetId = rodKarry.Id,
                ProduktId = wokBlanding.Id,
                Grams = wokBlanding.Grams,
            },
            new Ingrediens {
                RetId = rodKarry.Id,
                ProduktId = kokos.Id,
                Grams = kokos.Grams,
            },
            new Ingrediens {
                RetId = rodKarry.Id,
                ProduktId = log.Id,
                Grams = 150,
            },

            // Pasta salat
            new Ingrediens {
                RetId = pastaSalat.Id,
                ProduktId = fusilli.Id,
                Grams = 300,
            },
            new Ingrediens {
                RetId = pastaSalat.Id,
                ProduktId = edermame.Id,
                Grams = 300,
            },

            // Tærte
            new Ingrediens {
                RetId = taerte.Id,
                ProduktId = taertedej.Id,
                Grams = taertedej.Grams,
            },
            new Ingrediens {
                RetId = taerte.Id,
                ProduktId = egg.Id,
                Grams = 125
            },
            new Ingrediens {
                RetId = taerte.Id,
                ProduktId = hytteost.Id,
                Grams = 200
            },
            new Ingrediens {
                RetId = taerte.Id,
                ProduktId = spinat.Id,
                Grams = 100
            },
            new Ingrediens {
                RetId = taerte.Id,
                ProduktId = champignon.Id,
                Grams = 250
            },
            new Ingrediens {
                RetId = taerte.Id,
                ProduktId = skinkeStrimler.Id,
                Grams = 100
            },
            new Ingrediens {
                RetId = taerte.Id,
                ProduktId = milk.Id,
                Grams = 100
            },
            new Ingrediens {
                RetId = taerte.Id,
                ProduktId = revetOst.Id,
                Grams = 50
            },

            // Biksemad
            new Ingrediens {
                RetId = biksemad.Id,
                ProduktId = kartofel.Id,
                Grams = 500,
            },
            new Ingrediens {
                RetId = biksemad.Id,
                ProduktId = polse.Id,
                Note = "Tykstegsbøffer eller andet kød kan snild bruges",
                Grams = 250,
            },
            new Ingrediens {
                RetId = biksemad.Id,
                ProduktId = log.Id,
                Grams = 150,
            },
            new Ingrediens {
                RetId = biksemad.Id,
                ProduktId = egg.Id,
                Grams = 100,
            },

            // Panang
            new Ingrediens {
                RetId = panang.Id,
                ProduktId = kokos.Id,
                Grams = kokos.Grams,
            },
            new Ingrediens {
                RetId = panang.Id,
                ProduktId = wokBlanding.Id,
                Grams = wokBlanding.Grams,
            },
            new Ingrediens {
                RetId = panang.Id,
                ProduktId = ris.Id,
                Grams = 300,
            },

            // Ana
            new Ingrediens {
                RetId = ana.Id,
                ProduktId = samosa.Id,
                Grams = 1,
                Note = "2 samosaer"
            },
            new Ingrediens {
                RetId = ana.Id,
                ProduktId = storSalat.Id,
                Grams = 1,
                Note = "2 salater"
            },

            // Åses sandwich
            new Ingrediens {
                RetId = aasesSandwich.Id,
                ProduktId = pita.Id,
                Grams = 256
            },
            new Ingrediens {
                RetId = aasesSandwich.Id,
                ProduktId = spidskaal.Id,
                Grams = 200
            },
            new Ingrediens {
                RetId = aasesSandwich.Id,
                ProduktId = tomater.Id,
                Grams = 200
            },
            new Ingrediens {
                RetId = aasesSandwich.Id,
                ProduktId = agurk.Id,
                Grams = 150
            },
            new Ingrediens {
                RetId = aasesSandwich.Id,
                ProduktId = serano.Id,
                Grams = serano.Grams
            },
            new Ingrediens {
                RetId = aasesSandwich.Id,
                ProduktId = mozarellaBlok.Id,
                Grams = mozarellaBlok.Grams
            },
            new Ingrediens {
                RetId = aasesSandwich.Id,
                ProduktId = billigPesto.Id,
                Grams = 40
            },

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

            // Lasagne
            new Ingrediens {
                RetId = lasagne.Id,
                ProduktId = log.Id,
                Grams = 150
            },
            new Ingrediens {
                RetId = lasagne.Id,
                ProduktId = gulerodder.Id,
                Grams = 150
            },
            new Ingrediens {
                RetId = lasagne.Id,
                ProduktId = hakkedeTomater.Id,
                Grams = 400
            },
            new Ingrediens {
                RetId = lasagne.Id,
                ProduktId = tomatPurre.Id,
                Grams = 140
            },
            new Ingrediens {
                RetId = lasagne.Id,
                ProduktId = hakketOkse.Id,
                Grams = 500
            },
            new Ingrediens {
                RetId = lasagne.Id,
                ProduktId = lasagnePlader.Id,
                Grams = 250
            },
            new Ingrediens {
                RetId = lasagne.Id,
                ProduktId = bechamel.Id,
                Grams = 500
            },
            new Ingrediens {
                RetId = lasagne.Id,
                ProduktId = mozarellaBlok.Id,
                Grams = 125
            },

            // Pasta bolognese / kodsovs
            new Ingrediens {
                RetId = pastaKodsovs.Id,
                ProduktId = log.Id,
                Grams = 150
            },
            new Ingrediens {
                RetId = pastaKodsovs.Id,
                ProduktId = gulerodder.Id,
                Grams = 150
            },
            new Ingrediens {
                RetId = pastaKodsovs.Id,
                ProduktId = hakkedeTomater.Id,
                Grams = 400
            },
            new Ingrediens {
                RetId = pastaKodsovs.Id,
                ProduktId = tomatPurre.Id,
                Grams = 140
            },
            new Ingrediens {
                RetId = pastaKodsovs.Id,
                ProduktId = hakketOkse.Id,
                Grams = 500
            },

            // revet ost
            // paramsan
            
        };
    }
}
