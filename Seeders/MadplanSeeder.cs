
using Models;

namespace Seeders;

public class MadplanSeeder : ISeeder<Madplan>
{
    public List<Madplan> Seed()
    {
        return new List<Madplan> {
            new Madplan {
                Week = 17,
                Year = 2024,
            },
            new Madplan {
                Week = 16,
                Year = 2024,
            },
            new Madplan {
                Week = 15,
                Year = 2024,
            },
            new Madplan {
                Week = 14,
                Year = 2024,
            },
            new Madplan {
                Week = 13,
                Year = 2024,
            },
            new Madplan {
                Week = 12,
                Year = 2024,
            },
            new Madplan {
                Week = 11,
                Year = 2024,
            },
            new Madplan {
                Week = 10,
                Year = 2024,
            },
            new Madplan {
                Week = 9,
                Year = 2024,
            }
        };
    }
}