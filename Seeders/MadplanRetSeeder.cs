
using Models;

namespace Seeders;

public class MadplanRetSeeder : ISeeder<MadplanRet>
{
    private readonly List<Madplan> Madplaner;

    public MadplanRetSeeder(List<Madplan> madplaner)
    {
        Madplaner = madplaner;
    }

    public List<MadplanRet> Seed()
    {
        var madplanUge17= Madplaner.Where(m => m.Week == 17).First();
        var madplanUge16 = Madplaner.Where(m => m.Week == 16).First();
        var madplanUge15 = Madplaner.Where(m => m.Week == 15).First();
        var madplanUge14 = Madplaner.Where(m => m.Week == 14).First();
        var madplanUge13 = Madplaner.Where(m => m.Week == 13).First();
        var madplanUge12 = Madplaner.Where(m => m.Week == 12).First();
        var madplanUge11 = Madplaner.Where(m => m.Week == 11).First();
        var madplanUge10 = Madplaner.Where(m => m.Week == 10).First();
        var madplanUge9 = Madplaner.Where(m => m.Week == 9).First();

        return new List<MadplanRet> {
            // Uge 17
            new MadplanRet {
                MadplanId = madplanUge17.Id,
                RetId = 25,
                Order = 1,
            },
            new MadplanRet {
                MadplanId = madplanUge17.Id,
                RetId = 8,
                Order = 2
            },
            new MadplanRet {
                MadplanId = madplanUge17.Id,
                RetId = 27,
                Order = 3
            },
            new MadplanRet {
                MadplanId = madplanUge17.Id,
                RetId = 40,
                Order = 4
            },
            new MadplanRet {
                MadplanId = madplanUge17.Id,
                RetId = 11,
                Order = 5,
            },

            // Uge 16
            new MadplanRet {
                MadplanId = madplanUge16.Id,
                RetId = 23,
                Order = 1,
            },
            new MadplanRet {
                MadplanId = madplanUge16.Id,
                RetId = 18,
                Order = 2
            },
            new MadplanRet {
                MadplanId = madplanUge16.Id,
                RetId = 24,
                Order = 3
            },
            new MadplanRet {
                MadplanId = madplanUge16.Id,
                RetId = 9,
                Order = 4
            },
            new MadplanRet {
                MadplanId = madplanUge16.Id,
                RetId = 39,
                Order = 5,
            },

            // Uge 15
            new MadplanRet {
                MadplanId = madplanUge15.Id,
                RetId = 6,
                Order = 1,
            },
            new MadplanRet {
                MadplanId = madplanUge15.Id,
                RetId = 37,
                Order = 2
            },
            new MadplanRet {
                MadplanId = madplanUge15.Id,
                RetId = 22,
                Order = 3
            },
            new MadplanRet {
                MadplanId = madplanUge15.Id,
                RetId = 15,
                Order = 4
            },
            new MadplanRet {
                MadplanId = madplanUge15.Id,
                RetId = 33,
                Order = 5,
                Removed = true
            },

            // Uge 14
            new MadplanRet {
                MadplanId = madplanUge14.Id,
                RetId = 7,
                Order = 1,
                Removed = true,  
            },
            new MadplanRet {
                MadplanId = madplanUge14.Id,
                RetId = 18,
                Order = 2
            },
            new MadplanRet {
                MadplanId = madplanUge14.Id,
                RetId = 16,
                Order = 3
            },
            new MadplanRet {
                MadplanId = madplanUge14.Id,
                RetId = 9,
                Order = 4
            },
            new MadplanRet {
                MadplanId = madplanUge14.Id,
                RetId = 24,
                Order = 5
            },

            // Uge 13
            new MadplanRet {
                MadplanId = madplanUge13.Id,
                RetId = 25,
                Order = 1
            },
            new MadplanRet {
                MadplanId = madplanUge13.Id,
                RetId = 22,
                Order = 2
            },
            new MadplanRet {
                MadplanId = madplanUge13.Id,
                RetId = 40,
                Order = 3
            },
            new MadplanRet {
                MadplanId = madplanUge13.Id,
                RetId = 14,
                Order = 4
            },
            new MadplanRet {
                MadplanId = madplanUge13.Id,
                RetId = 37,
                Order = 5
            },

            // Uge 12
            new MadplanRet {
                MadplanId = madplanUge12.Id,
                RetId = 30,
                Order = 1
            },
            new MadplanRet {
                MadplanId = madplanUge12.Id,
                RetId = 16,
                Order = 2,
            },
            new MadplanRet {
                MadplanId = madplanUge12.Id,
                RetId = 3,
                Order = 3
            },
            new MadplanRet {
                MadplanId = madplanUge12.Id,
                RetId = 12,
                Order = 4
            },
            new MadplanRet {
                MadplanId = madplanUge12.Id,
                RetId = 26,
                Order = 5
            },

            // Uge 11
            new MadplanRet {
                MadplanId = madplanUge11.Id,
                RetId = 40,
                Order = 1
            },
            new MadplanRet {
                MadplanId = madplanUge11.Id,
                RetId = 20,
                Order = 2,
            },
            new MadplanRet {
                MadplanId = madplanUge11.Id,
                RetId = 29,
                Order = 3
            },
            new MadplanRet {
                MadplanId = madplanUge11.Id,
                RetId = 37,
                Order = 4
            },
            new MadplanRet {
                MadplanId = madplanUge11.Id,
                RetId = 34,
                Order = 5
            },

            // Uge 10
            new MadplanRet {
                MadplanId = madplanUge10.Id,
                RetId = 12,
                Order = 1
            },
            new MadplanRet {
                MadplanId = madplanUge10.Id,
                RetId = 22,
                Order = 2,
            },
            new MadplanRet {
                MadplanId = madplanUge10.Id,
                RetId = 25,
                Order = 3
            },
            new MadplanRet {
                MadplanId = madplanUge10.Id,
                RetId = 15,
                Order = 4
            },
            new MadplanRet {
                MadplanId = madplanUge10.Id,
                RetId = 4,
                Order = 5
            },

            // Uge 9
            new MadplanRet {
                MadplanId = madplanUge9.Id,
                RetId = 13,
                Order = 1
            },
            new MadplanRet {
                MadplanId = madplanUge9.Id,
                RetId = 23,
                Order = 2,
            },
            new MadplanRet {
                MadplanId = madplanUge9.Id,
                RetId = 26,
                Order = 3
            },
            new MadplanRet {
                MadplanId = madplanUge9.Id,
                RetId = 16,
                Order = 4
            },
            new MadplanRet {
                MadplanId = madplanUge9.Id,
                RetId = 2,
                Order = 5
            },
        };
    }
}