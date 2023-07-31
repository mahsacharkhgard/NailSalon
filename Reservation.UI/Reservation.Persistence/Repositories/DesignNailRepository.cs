using Reservation.Model.Models;
using Reservation.Persistence.Contexts;
using Reservation.Persistence.IRepositories;

namespace Reservation.Persistence.Repositories
{
    public class DesignNailRepository : IDesignNailRepository
    {
        private readonly ReservationContext context;
        public DesignNailRepository(ReservationContext context)
        {
            this.context = context;
        }

        public int Add(DesignNail designNail)
        {
            context.Add(designNail);
            return context.SaveChanges();
        }

        public IQueryable<DesignNail> GetAll()
        {
            return context.DesignNail;
        }

        public IQueryable<DesignNail> GetById(int id)
        {
            return context.DesignNail.Where(x => x.Id == id);
        }

        public int Delete(int id)
        {
            context.Remove(id);
            return context.SaveChanges();
        }

        public IQueryable<DesignNail> SearchByKeyWord(string keyword)
        {
            return context.DesignNail.Where(x => x.Name == keyword);
        }

        public int Update(DesignNail designNail)
        {
            context.Update(designNail);
            return context.SaveChanges();
        }
    }
}
