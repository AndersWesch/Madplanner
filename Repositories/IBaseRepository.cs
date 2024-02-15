
namespace Repositories;


public interface IBaseRepository<TEntity>
{
    TEntity Create(TEntity entity);

    void Delete(TEntity entity);

    TEntity Update(TEntity entity);

    TEntity? GetById(int id);

    List<TEntity> GetAll();
}
