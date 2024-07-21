using Database;
using Models;

namespace Seeders;

public class IngrediensSeeder : ISeeder<Ingrediens>
{    
    private DatabaseContext _databaseContext;

    public IngrediensSeeder(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public List<Ingrediens> Seed()
    {
        // Retter
        var aasesSandwich = _databaseContext.Retter.Where(r => r.SeedKey == "aase").FirstOrDefault();
        var ana = _databaseContext.Retter.Where(r => r.SeedKey == "ana").FirstOrDefault();
        var beluga = _databaseContext.Retter.Where(r => r.SeedKey == "beluga").First();
        var biksemad = _databaseContext.Retter.Where(r => r.SeedKey == "biksemad").FirstOrDefault();
        var burger = _databaseContext.Retter.Where(r => r.SeedKey == "burger").First();
        var dhal = _databaseContext.Retter.Where(r => r.SeedKey == "dhal").First();
        var lasagne = _databaseContext.Retter.Where(r => r.SeedKey == "lasagne").FirstOrDefault();
        var panang = _databaseContext.Retter.Where(r => r.SeedKey == "panang").FirstOrDefault();
        var pastaKodsovs = _databaseContext.Retter.Where(r => r.SeedKey == "pasta-kodsovs").FirstOrDefault();
        var pastaSalat = _databaseContext.Retter.Where(r => r.SeedKey == "pasta-salat").FirstOrDefault();
        var quinoaSalat = _databaseContext.Retter.Where(r => r.SeedKey == "quinoa").First();
        var rodKarry = _databaseContext.Retter.Where(r => r.SeedKey == "rod-karry").First();
        var rodpasta = _databaseContext.Retter.Where(r => r.SeedKey == "rodpasta").FirstOrDefault();
        var taerte = _databaseContext.Retter.Where(r => r.SeedKey == "taerte").FirstOrDefault();
        var tomatsuppe = _databaseContext.Retter.Where(r => r.SeedKey == "tomatsuppe").FirstOrDefault();
        var tortelliniSalat = _databaseContext.Retter.Where(r => r.SeedKey == "tortellini-salat").First();
        var tortillasOkse = _databaseContext.Retter.Where(r => r.SeedKey == "tortillas-okse").First();
        var tortillasFalafel = _databaseContext.Retter.Where(r => r.SeedKey == "tortillas-falafel").First();
        var tortillasKylling = _databaseContext.Retter.Where(r => r.SeedKey == "tortillas-kylling").First();

        // Produkter
        var agurk = _databaseContext.Produkter.Where(r => r.SeedKey == "agurk").FirstOrDefault();
        var bechamel = _databaseContext.Produkter.Where(r => r.SeedKey == "bechamel").FirstOrDefault();
        var billigPesto = _databaseContext.Produkter.Where(r => r.SeedKey == "billig-pesto").FirstOrDefault();
        var burgerboller = _databaseContext.Produkter.Where(r => r.SeedKey == "burgerboller").First();
        var champignon = _databaseContext.Produkter.Where(r => r.SeedKey == "champignon").FirstOrDefault();
        var cherrytomater = _databaseContext.Produkter.Where(r => r.SeedKey == "cherrytomater").First();
        var chilibeans = _databaseContext.Produkter.Where(r => r.SeedKey == "chilibeans").First();
        var curlyFries = _databaseContext.Produkter.Where(r => r.SeedKey == "curly-fries").First();
        var edermame = _databaseContext.Produkter.Where(r => r.SeedKey == "edermame").First();
        var egg = _databaseContext.Produkter.Where(r => r.SeedKey == "egg").FirstOrDefault();

        
        var falafel = _databaseContext.Produkter.Where(r => r.SeedKey == "falafel").First();
        var fusilli = _databaseContext.Produkter.Where(r => r.SeedKey == "fusilli").First();
        var godPesto = _databaseContext.Produkter.Where(r => r.SeedKey == "pesto-god").First();
        var grontsagsbouillon = _databaseContext.Produkter.Where(r => r.SeedKey == "grontsagsbouillon").First();
        var gulerodder = _databaseContext.Produkter.Where(r => r.SeedKey == "gulerodder").FirstOrDefault();
        var hakkedeTomater = _databaseContext.Produkter.Where(r => r.SeedKey == "hakkede-tomater").FirstOrDefault();
        var hakketOkse = _databaseContext.Produkter.Where(r => r.SeedKey == "hakket-okse").FirstOrDefault();
        var hvidlog = _databaseContext.Produkter.Where(r => r.SeedKey == "hvidlog").First();
        var hytteost = _databaseContext.Produkter.Where(r => r.SeedKey == "hytteost").FirstOrDefault();
        var ingefaer = _databaseContext.Produkter.Where(r => r.SeedKey == "ingefaer").First();
        var karolinetomatsuppe = _databaseContext.Produkter.Where(r => r.SeedKey == "karoline-tomat").FirstOrDefault();
        var kartofel = _databaseContext.Produkter.Where(r => r.SeedKey == "kartofel").FirstOrDefault();
        var kikaerter = _databaseContext.Produkter.Where(r => r.SeedKey == "kikaerter").First();
        var kyllingeBryst = _databaseContext.Produkter.Where(r => r.SeedKey == "kylling-bryst").FirstOrDefault();
        var kokos = _databaseContext.Produkter.Where(r => r.SeedKey == "kokos").FirstOrDefault();
        var lasagnePlader = _databaseContext.Produkter.Where(r => r.SeedKey == "lasagne-plader").FirstOrDefault();
        var log = _databaseContext.Produkter.Where(r => r.SeedKey == "log").FirstOrDefault();
        var madlavningsflode = _databaseContext.Produkter.Where(r => r.SeedKey == "madlavningsflode").First();
        var majs = _databaseContext.Produkter.Where(r => r.SeedKey == "majs").First();
        var milk = _databaseContext.Produkter.Where(r => r.SeedKey == "milk").FirstOrDefault();
        var mozarellaBlok = _databaseContext.Produkter.Where(r => r.SeedKey == "mozarella-blok").FirstOrDefault();
        var parmasan = _databaseContext.Produkter.Where(r => r.SeedKey == "parmasan").First();
        var pita = _databaseContext.Produkter.Where(r => r.SeedKey == "pita").FirstOrDefault();
        var polse = _databaseContext.Produkter.Where(r => r.SeedKey == "polse").FirstOrDefault();
        var quinoa = _databaseContext.Produkter.Where(r => r.SeedKey == "quinoa").First();
        var revetOst = _databaseContext.Produkter.Where(r => r.SeedKey == "revet-ost").FirstOrDefault();
        var ris = _databaseContext.Produkter.Where(r => r.SeedKey == "ris").FirstOrDefault();
        var rodeLinser = _databaseContext.Produkter.Where(r => r.SeedKey == "rode-linser").First();
        var rodLog = _databaseContext.Produkter.Where(r => r.SeedKey == "rod-log").First();
        var salatost = _databaseContext.Produkter.Where(r => r.SeedKey == "salatost").First();
        var salsiccia = _databaseContext.Produkter.Where(r => r.SeedKey == "salsiccia").First();
        var samosa = _databaseContext.Produkter.Where(r => r.SeedKey == "samosa").FirstOrDefault();
        var serano = _databaseContext.Produkter.Where(r => r.SeedKey == "serano").FirstOrDefault();
        var skinkeStrimler = _databaseContext.Produkter.Where(r => r.SeedKey == "skinke-strimler").FirstOrDefault();
        var spidskaal = _databaseContext.Produkter.Where(r => r.SeedKey == "spidskaal").FirstOrDefault();
        var spinat = _databaseContext.Produkter.Where(r => r.SeedKey == "spinat").FirstOrDefault();
        var storSalat = _databaseContext.Produkter.Where(r => r.SeedKey == "stor-salat").FirstOrDefault();
        var suppehorn = _databaseContext.Produkter.Where(r => r.SeedKey == "suppehorn").FirstOrDefault();
        var taertedej = _databaseContext.Produkter.Where(r => r.SeedKey == "taertedej").FirstOrDefault();
        var tomater = _databaseContext.Produkter.Where(r => r.SeedKey == "tomater").FirstOrDefault();
        var tomatPurre = _databaseContext.Produkter.Where(r => r.SeedKey == "tomat-purre").FirstOrDefault();
        var tortellini = _databaseContext.Produkter.Where(r => r.SeedKey == "tortellini").First();
        var tortiglioni = _databaseContext.Produkter.Where(r => r.SeedKey == "tortiglioni").First();
        var tortillas = _databaseContext.Produkter.Where(r => r.SeedKey == "tortillas").First();
        var wokBlanding = _databaseContext.Produkter.Where(r => r.SeedKey == "wok-blanding").FirstOrDefault();

        return new List<Ingrediens>{
            // Pasta salat
            
            // Burger
            new Ingrediens {
                RetId = burger.Id,
                ProduktId = burgerboller.Id,
                Grams = burgerboller.Grams,
            },
            new Ingrediens {
                RetId = burger.Id,
                ProduktId = hakketOkse.Id,
                Grams = hakketOkse.Grams,
            },
            new Ingrediens {
                RetId = burger.Id,
                ProduktId = log.Id,
                Grams = 100
            },
            new Ingrediens {
                RetId = burger.Id,
                ProduktId = tomater.Id,
                Grams = 200
            },
            new Ingrediens {
                RetId = burger.Id,
                ProduktId = agurk.Id,
                Grams = 150
            },
            //new Ingrediens {
            //    RetId = burger.Id,
            //    ProduktId = curlyFries.Id,
            //    Grams = curlyFries.Grams
            //},
            
            // Tortellini salat
            new Ingrediens {
                RetId = tortelliniSalat.Id,
                ProduktId = tortellini.Id,
                Grams = tortellini.Grams,
            },
            new Ingrediens {
                RetId = tortelliniSalat.Id,
                ProduktId = spinat.Id,
                Grams = spinat.Grams,
            },
            new Ingrediens {
                RetId = tortelliniSalat.Id,
                ProduktId = tomater.Id,
                Grams = 200,
            },
            new Ingrediens {
                RetId = tortelliniSalat.Id,
                ProduktId = agurk.Id,
                Grams = 150,
            },
            new Ingrediens {
                RetId = tortelliniSalat.Id,
                ProduktId = edermame.Id,
                Grams = 150,
            },
            new Ingrediens {
                RetId = tortelliniSalat.Id,
                ProduktId = godPesto.Id,
                Grams = godPesto.Grams,
            },
            new Ingrediens {
                RetId = tortelliniSalat.Id,
                ProduktId = revetOst.Id,
                Grams = 125,
            },

            // Dhal
            new Ingrediens {
                RetId = dhal.Id,
                ProduktId = ris.Id,
                Grams = 250,
            },
            new Ingrediens {
                RetId = dhal.Id,
                ProduktId = hvidlog.Id,
                Grams = 10,
            },
            new Ingrediens {
                RetId = dhal.Id,
                ProduktId = ingefaer.Id,
                Grams = 75,
            },
            new Ingrediens {
                RetId = dhal.Id,
                ProduktId = grontsagsbouillon.Id,
                Grams = 10,
            },
            new Ingrediens {
                RetId = dhal.Id,
                ProduktId = rodeLinser.Id,
                Grams = 200,
            },
            new Ingrediens {
                RetId = dhal.Id,
                ProduktId = hakkedeTomater.Id,
                Grams = hakkedeTomater.Grams * 2,
            },

            // Rød pasta
            new Ingrediens {
                RetId = rodpasta.Id,
                ProduktId = tortiglioni.Id,
                Grams = 300,
            },
            new Ingrediens {
                RetId = rodpasta.Id,
                ProduktId = hakkedeTomater.Id,
                Grams = hakkedeTomater.Grams,
            },
            new Ingrediens {
                RetId = rodpasta.Id,
                ProduktId = madlavningsflode.Id,
                Grams = 200,
            },
            new Ingrediens {
                RetId = rodpasta.Id,
                ProduktId = salsiccia.Id,
                Grams = salsiccia.Grams,
            },

            // Beluga Bolognese 
            new Ingrediens {
                RetId = beluga.Id,
                ProduktId = log.Id,
                Grams = 150,
            },
            new Ingrediens {
                RetId = beluga.Id,
                ProduktId = fusilli.Id,
                Grams = 250,
            },
            new Ingrediens {
                RetId = beluga.Id,
                ProduktId = tomatPurre.Id,
                Grams = tomatPurre.Grams,
            },
            new Ingrediens {
                RetId = beluga.Id,
                ProduktId = hakkedeTomater.Id,
                Grams = hakkedeTomater.Grams,
            },
            new Ingrediens {
                RetId = beluga.Id,
                ProduktId = parmasan.Id,
                Grams = 50,
            },
            new Ingrediens {
                RetId = beluga.Id,
                ProduktId = gulerodder.Id,
                Grams = 150,
            },
            // Beluga linser
            // Rødvin
            // Hvidløg
            // Fløde / MAdlavningsfløde

            // Quinoa Salat 
            new Ingrediens {
                RetId = quinoaSalat.Id,
                ProduktId = rodLog.Id,
                Grams = 150,
            },
            new Ingrediens {
                RetId = quinoaSalat.Id,
                ProduktId = kikaerter.Id,
                Grams = kikaerter.Grams,
            },
            new Ingrediens {
                RetId = quinoaSalat.Id,
                ProduktId = agurk.Id,
                Grams = 150,
            },
            new Ingrediens {
                RetId = quinoaSalat.Id,
                ProduktId = quinoa.Id,
                Grams = 200,
            },
            new Ingrediens {
                RetId = quinoaSalat.Id,
                ProduktId = salatost.Id,
                Grams = 150,
            },
            new Ingrediens {
                RetId = quinoaSalat.Id,
                ProduktId = cherrytomater.Id,
                Grams = 200,
            },

            // Gul peber
            // Rucula
            // Persille

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
            new Ingrediens {
                RetId = tortillasOkse.Id,
                ProduktId = tortillas.Id,
                Grams = 250,
            },
            new Ingrediens {
                RetId = tortillasOkse.Id,
                ProduktId = majs.Id,
                Grams = majs.Grams,
            },
            new Ingrediens {
                RetId = tortillasOkse.Id,
                ProduktId = chilibeans.Id,
                Grams = chilibeans.Grams,
            },
            new Ingrediens {
                RetId = tortillasOkse.Id,
                ProduktId = revetOst.Id,
                Grams = 125,
            },

            // Tortilla falafel
            new Ingrediens {
                RetId = tortillasFalafel.Id,
                ProduktId = spidskaal.Id,
                Grams = 150,
            },
            new Ingrediens {
                RetId = tortillasFalafel.Id,
                ProduktId = tomater.Id,
                Grams = 200,
            },
            new Ingrediens {
                RetId = tortillasFalafel.Id,
                ProduktId = agurk.Id,
                Grams = 150,
            },
            new Ingrediens {
                RetId = tortillasFalafel.Id,
                ProduktId = tortillas.Id,
                Grams = 250,
            },
            new Ingrediens {
                RetId = tortillasFalafel.Id,
                ProduktId = majs.Id,
                Grams = majs.Grams,
            },
            new Ingrediens {
                RetId = tortillasFalafel.Id,
                ProduktId = chilibeans.Id,
                Grams = chilibeans.Grams,
            },
            new Ingrediens {
                RetId = tortillasFalafel.Id,
                ProduktId = falafel.Id,
                Grams = 250,
            },
            new Ingrediens {
                RetId = tortillasFalafel.Id,
                ProduktId = revetOst.Id,
                Grams = 125,
            },

            // Tortilla kylling
            new Ingrediens {
                RetId = tortillasKylling.Id,
                ProduktId = spidskaal.Id,
                Grams = 150,
            },
            new Ingrediens {
                RetId = tortillasKylling.Id,
                ProduktId = tomater.Id,
                Grams = 200,
            },
            new Ingrediens {
                RetId = tortillasKylling.Id,
                ProduktId = agurk.Id,
                Grams = 150,
            },
            new Ingrediens {
                RetId = tortillasKylling.Id,
                ProduktId = tortillas.Id,
                Grams = 250,
            },
            new Ingrediens {
                RetId = tortillasKylling.Id,
                ProduktId = majs.Id,
                Grams = majs.Grams,
            },
            new Ingrediens {
                RetId = tortillasKylling.Id,
                ProduktId = chilibeans.Id,
                Grams = chilibeans.Grams,
            },
            new Ingrediens {
                RetId = tortillasKylling.Id,
                ProduktId = kyllingeBryst.Id,
                Grams = kyllingeBryst.Grams,
            },
            new Ingrediens {
                RetId = tortillasKylling.Id,
                ProduktId = revetOst.Id,
                Grams = 125,
            },
            

            // Rød Karry
            new Ingrediens {
                RetId = rodKarry.Id,
                ProduktId = ris.Id,
                Grams = 250,
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
            new Ingrediens {
                RetId = rodKarry.Id,
                ProduktId = tomatPurre.Id,
                Grams = tomatPurre.Grams,
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
                Grams = 250,
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
            new Ingrediens {
                RetId = pastaKodsovs.Id,
                ProduktId = parmasan.Id,
                Grams = 50
            },
            new Ingrediens {
                RetId = pastaKodsovs.Id,
                ProduktId = revetOst.Id,
                Grams = 100
            },
        };
    }
}
