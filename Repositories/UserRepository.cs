using Models;

namespace Repositories;

public class UserRepository : BaseRepository<User>
{
    public User? GetByEmail(string email)
    {
        return DbContext.Users.FirstOrDefault(u => u.Email == email);
    }

    public User? GetBytoken(Guid token)
    {
        return DbContext.Users.FirstOrDefault(u => u.Token == token);
    }
}
