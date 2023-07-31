using Reservation.Model.Models;

namespace Reservation.Infrastructure.IRepositories
{
    public interface IBaseRepository<TEntity, TKey>
        where TEntity : BaseEntity<TKey>, new()
        where TKey : struct
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(TKey id);
        TKey Add(TEntity entity);
        TKey Update(TEntity entity);
        TKey Delete(TEntity entity);
    }
}
