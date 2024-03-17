
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
        var madplanUge12 = Madplaner.Where(m => m.Week == 12).First();
        var madplanUge11 = Madplaner.Where(m => m.Week == 11).First();
        var madplanUge10 = Madplaner.Where(m => m.Week == 10).First();
        var madplanUge9 = Madplaner.Where(m => m.Week == 9).First();

        return new List<MadplanRet> {
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