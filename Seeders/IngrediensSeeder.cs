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
        var aasesSandwich = DbContext.Retter.Where(r => r.SeedKey == "aase").FirstOrDefault();
        var ana = DbContext.Retter.Where(r => r.SeedKey == "ana").FirstOrDefault();
        var beluga = DbContext.Retter.Where(r => r.SeedKey == "beluga").First();
        var biksemad = DbContext.Retter.Where(r => r.SeedKey == "biksemad").FirstOrDefault();
        var burger = DbContext.Retter.Where(r => r.SeedKey == "burger").First();
        var dhal = DbContext.Retter.Where(r => r.SeedKey == "dhal").First();
        var lasagne = DbContext.Retter.Where(r => r.SeedKey == "lasagne").FirstOrDefault();
        var panang = DbContext.Retter.Where(r => r.SeedKey == "panang").FirstOrDefault();
        var pastaKodsovs = DbContext.Retter.Where(r => r.SeedKey == "pasta-kodsovs").FirstOrDefault();
        var pastaSalat = DbContext.Retter.Where(r => r.SeedKey == "pasta-salat").FirstOrDefault();
        var quinoaSalat = DbContext.Retter.Where(r => r.SeedKey == "quinoa").First();
        var rodKarry = DbContext.Retter.Where(r => r.SeedKey == "rod-karry").First();
        var rodpasta = DbContext.Retter.Where(r => r.SeedKey == "rodpasta").FirstOrDefault();
        var taerte = DbContext.Retter.Where(r => r.SeedKey == "taerte").FirstOrDefault();
        var tomatsuppe = DbContext.Retter.Where(r => r.SeedKey == "tomatsuppe").FirstOrDefault();
        var tortelliniSalat = DbContext.Retter.Where(r => r.SeedKey == "tortellini-salat").First();
        var tortillasOkse = DbContext.Retter.Where(r => r.SeedKey == "tortillas-okse").First();
        var tortillasFalafel = DbContext.Retter.Where(r => r.SeedKey == "tortillas-falafel").First();
        var tortillasKylling = DbContext.Retter.Where(r => r.SeedKey == "tortillas-kylling").First();

        // Produkter
        var agurk = DbContext.Produkter.Where(r => r.SeedKey == "agurk").FirstOrDefault();
        var bechamel = DbContext.Produkter.Where(r => r.SeedKey == "bechamel").FirstOrDefault();
        var billigPesto = DbContext.Produkter.Where(r => r.SeedKey == "billig-pesto").FirstOrDefault();
        var burgerboller = DbContext.Produkter.Where(r => r.SeedKey == "burgerboller").First();
        var champignon = DbContext.Produkter.Where(r => r.SeedKey == "champignon").FirstOrDefault();
        var cherrytomater = DbContext.Produkter.Where(r => r.SeedKey == "cherrytomater").First();
        var chilibeans = DbContext.Produkter.Where(r => r.SeedKey == "chilibeans").First();
        var curlyFries = DbContext.Produkter.Where(r => r.SeedKey == "curly-fries").First();
        var edermame = DbContext.Produkter.Where(r => r.SeedKey == "edermame").First();
        var egg = DbContext.Produkter.Where(r => r.SeedKey == "egg").FirstOrDefault();

        
        var falafel = DbContext.Produkter.Where(r => r.SeedKey == "falafel").First();
        var fusilli = DbContext.Produkter.Where(r => r.SeedKey == "fusilli").First();
        var godPesto = DbContext.Produkter.Where(r => r.SeedKey == "pesto-god").First();
        var grontsagsbouillon = DbContext.Produkter.Where(r => r.SeedKey == "grontsagsbouillon").First();
        var gulerodder = DbContext.Produkter.Where(r => r.SeedKey == "gulerodder").FirstOrDefault();
        var hakkedeTomater = DbContext.Produkter.Where(r => r.SeedKey == "hakkede-tomater").FirstOrDefault();
        var hakketOkse = DbContext.Produkter.Where(r => r.SeedKey == "hakket-okse").FirstOrDefault();
        var hvidlog = DbContext.Produkter.Where(r => r.SeedKey == "hvidlog").First();
        var hytteost = DbContext.Produkter.Where(r => r.SeedKey == "hytteost").FirstOrDefault();
        var ingefaer = DbContext.Produkter.Where(r => r.SeedKey == "ingefaer").First();
        var karolinetomatsuppe = DbContext.Produkter.Where(r => r.SeedKey == "karoline-tomat").FirstOrDefault();
        var kartofel = DbContext.Produkter.Where(r => r.SeedKey == "kartofel").FirstOrDefault();
        var kikaerter = DbContext.Produkter.Where(r => r.SeedKey == "kikaerter").First();
        var kyllingeBryst = DbContext.Produkter.Where(r => r.SeedKey == "kylling-bryst").FirstOrDefault();
        var kokos = DbContext.Produkter.Where(r => r.SeedKey == "kokos").FirstOrDefault();
        var lasagnePlader = DbContext.Produkter.Where(r => r.SeedKey == "lasagne-plader").FirstOrDefault();
        var log = DbContext.Produkter.Where(r => r.SeedKey == "log").FirstOrDefault();
        var madlavningsflode = DbContext.Produkter.Where(r => r.SeedKey == "madlavningsflode").First();
        var majs = DbContext.Produkter.Where(r => r.SeedKey == "majs").First();
        var milk = DbContext.Produkter.Where(r => r.SeedKey == "milk").FirstOrDefault();
        var mozarellaBlok = DbContext.Produkter.Where(r => r.SeedKey == "mozarella-blok").FirstOrDefault();
        var parmasan = DbContext.Produkter.Where(r => r.SeedKey == "parmasan").First();
        var pita = DbContext.Produkter.Where(r => r.SeedKey == "pita").FirstOrDefault();
        var polse = DbContext.Produkter.Where(r => r.SeedKey == "polse").FirstOrDefault();
        var quinoa = DbContext.Produkter.Where(r => r.SeedKey == "quinoa").First();
        var revetOst = DbContext.Produkter.Where(r => r.SeedKey == "revet-ost").FirstOrDefault();
        var ris = DbContext.Produkter.Where(r => r.SeedKey == "ris").FirstOrDefault();
        var rodeLinser = DbContext.Produkter.Where(r => r.SeedKey == "rode-linser").First();
        var rodLog = DbContext.Produkter.Where(r => r.SeedKey == "rod-log").First();
        var salatost = DbContext.Produkter.Where(r => r.SeedKey == "salatost").First();
        var salsiccia = DbContext.Produkter.Where(r => r.SeedKey == "salsiccia").First();
        var samosa = DbContext.Produkter.Where(r => r.SeedKey == "samosa").FirstOrDefault();
        var serano = DbContext.Produkter.Where(r => r.SeedKey == "serano").FirstOrDefault();
        var skinkeStrimler = DbContext.Produkter.Where(r => r.SeedKey == "skinke-strimler").FirstOrDefault();
        var spidskaal = DbContext.Produkter.Where(r => r.SeedKey == "spidskaal").FirstOrDefault();
        var spinat = DbContext.Produkter.Where(r => r.SeedKey == "spinat").FirstOrDefault();
        var storSalat = DbContext.Produkter.Where(r => r.SeedKey == "stor-salat").FirstOrDefault();
        var suppehorn = DbContext.Produkter.Where(r => r.SeedKey == "suppehorn").FirstOrDefault();
        var taertedej = DbContext.Produkter.Where(r => r.SeedKey == "taertedej").FirstOrDefault();
        var tomater = DbContext.Produkter.Where(r => r.SeedKey == "tomater").FirstOrDefault();
        var tomatPurre = DbContext.Produkter.Where(r => r.SeedKey == "tomat-purre").FirstOrDefault();
        var tortellini = DbContext.Produkter.Where(r => r.SeedKey == "tortellini").First();
        var tortiglioni = DbContext.Produkter.Where(r => r.SeedKey == "tortiglioni").First();
        var tortillas = DbContext.Produkter.Where(r => r.SeedKey == "tortillas").First();
        var wokBlanding = DbContext.Produkter.Where(r => r.SeedKey == "wok-blanding").FirstOrDefault();

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
