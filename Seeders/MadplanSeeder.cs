
using Models;

namespace Seeders;

public class MadplanSeeder : ISeeder<Madplan>
{
    private readonly List<Ret> Retter;
    
    public MadplanSeeder(List<Ret> retter) 
    {
        Retter = retter;
    }

    public List<Madplan> Seed()
    {
        return new List<Madplan> {
            new Madplan {
                Week = 8,
                Year = 2024,
            },
            new Madplan {
                Week = 7,
                Year = 2024,
            }
        };
    }
}