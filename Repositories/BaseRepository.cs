using Database;
using Seeders;

namespace Repositories;

public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    protected readonly DatabaseContext DbContext;

    protected BaseRepository()
    {
        DbContext = new DatabaseContext();

        if (!DbContext.Retter.Any()) {
            Seed();
        }
    }
    
    public TEntity Create(TEntity entity)
    {
        DbContext.Set<TEntity>().Add(entity);
        DbContext.SaveChanges();
        return entity;
    }

    public TEntity Update(TEntity entity)
    {
        DbContext.SaveChanges();
        return entity;
    }

    public TEntity GetById(int id)
    {
        var entity = DbContext.Set<TEntity>().Find(id);

        if (entity == null)
        {
            throw new Exception($"Could not find {typeof(TEntity).Name} by id: {id}");
        }

        return entity;
    }

    public List<TEntity> GetAll()
    {
        return DbContext.Set<TEntity>().ToList();
    }

    public void Delete(TEntity entity)
    {
        DbContext.Set<TEntity>().Remove(entity);
        DbContext.SaveChanges();
    }

    private void Seed()
    {
        Console.WriteLine("Seeding data");

        var produktSeeder = new ProduktSeeder();
        var produkter = produktSeeder.Seed();
        DbContext.Produkter.AddRange(produkter);

        var retSeeder = new RetSeeder();
        var retter = retSeeder.Seed();
        DbContext.Retter.AddRange(retter);

        DbContext.SaveChanges();

        var ingrediensSeeder = new IngrediensSeeder();
        var ingredienser = ingrediensSeeder.Seed();
        DbContext.Ingredienser.AddRange(ingredienser);

        var madplanSeeder = new MadplanSeeder(retter.Take(5).ToList());
        var madplaner = madplanSeeder.Seed();
        DbContext.Madplaner.AddRange(madplaner);

        DbContext.SaveChanges();
    }
}
