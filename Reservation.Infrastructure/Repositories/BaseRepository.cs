using Microsoft.EntityFrameworkCore;
using Reservation.Infrastructure.Contexts;
using Reservation.Infrastructure.IRepositories;
using Reservation.Model.Models;

namespace Reservation.Infrastructure.Repositories
{
    public class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey>
        where TEntity : BaseEntity<TKey>, new()
        where TKey : struct
    {
        private readonly ReservationContext context;
        public BaseRepository(ReservationContext context)
        {
            this.context = context;
        }

        public TKey Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public TKey Delete(TEntity entity)
        {
            context.Remove(entity);
            context.SaveChanges();
            return entity.Id;
        }

        public IQueryable<TEntity> GetAll()
        {
            var entities = context.Set<TEntity>().ToList();
            return entities.AsQueryable();
        }

        public TEntity GetById(TKey id)
        {
            throw new NotImplementedException();
        }

        public TKey Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
