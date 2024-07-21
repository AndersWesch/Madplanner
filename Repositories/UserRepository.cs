using Database;
using Models;

namespace Repositories;

public class UserRepository : BaseRepository<User>
{
    

    public UserRepository(DatabaseContext dbContext) : base(dbContext)
    {
    }
    
    public User? GetByEmail(string email)
    {
        return _databaseContext.Users.FirstOrDefault(u => u.Email == email);
    }

    public User? GetBytoken(Guid token)
    {
        return _databaseContext.Users.FirstOrDefault(u => u.Token == token);
    }
}
