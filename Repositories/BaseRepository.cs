using Database;
using Seeders;

namespace Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    protected DatabaseContext _databaseContext;

    protected BaseRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;

        if (!_databaseContext.Retter.Any()) {
            Seed();
        }
    }
    
    public TEntity Create(TEntity entity)
    {
        _databaseContext.Set<TEntity>().Add(entity);
        _databaseContext.SaveChanges();
        return entity;
    }

    public TEntity Update(TEntity entity)
    {
        _databaseContext.SaveChanges();
        return entity;
    }

    public TEntity GetById(int id)
    {
        var entity = _databaseContext.Set<TEntity>().Find(id);

        if (entity == null)
        {
            throw new Exception($"Could not find {typeof(TEntity).Name} by id: {id}");
        }

        return entity;
    }

    public List<TEntity> GetAll()
    {
        return _databaseContext.Set<TEntity>().ToList();
    }

    public void Delete(TEntity entity)
    {
        _databaseContext.Set<TEntity>().Remove(entity);
        _databaseContext.SaveChanges();
    }

    private void Seed()
    {
        Console.WriteLine("Seeding data");

        Console.WriteLine("Users");
        var userSeeder = new UserSeeder();
        var users = userSeeder.Seed();
        _databaseContext.Users.AddRange(users);

        Console.WriteLine("Produkter");
        var produktSeeder = new ProduktSeeder();
        var produkter = produktSeeder.Seed();
        _databaseContext.Produkter.AddRange(produkter);

        Console.WriteLine("Retter");
        var retSeeder = new RetSeeder();
        var retter = retSeeder.Seed();
        _databaseContext.Retter.AddRange(retter);

        _databaseContext.SaveChanges();

        Console.WriteLine("Ingredienser");
        var ingrediensSeeder = new IngrediensSeeder(_databaseContext);
        var ingredienser = ingrediensSeeder.Seed();
        _databaseContext.Ingredienser.AddRange(ingredienser);

        Console.WriteLine("Madplaner");
        var madplanSeeder = new MadplanSeeder();
        var madplaner = madplanSeeder.Seed();
        _databaseContext.Madplaner.AddRange(madplaner);

        _databaseContext.SaveChanges();

        Console.WriteLine("MadplanRetter");
        var madplanRetSeeder = new MadplanRetSeeder(madplaner);
        var madplanRetter = madplanRetSeeder.Seed();
        _databaseContext.MadplanRetter.AddRange(madplanRetter);

        _databaseContext.SaveChanges();
    }
}
