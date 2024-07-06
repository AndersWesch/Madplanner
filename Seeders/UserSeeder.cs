using Models;

namespace Seeders;

public class UserSeeder : ISeeder<User>
{
    public List<User> Seed()
    {
        return new List<User> {
            new User { 
                Id = 1,
                Name = "Anders Wesch",
                Email = "anderswesch@gmail.com",
            }

        };
    }
}
