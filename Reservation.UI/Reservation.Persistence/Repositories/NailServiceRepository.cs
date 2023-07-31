using Reservation.Model.Models;
using Reservation.Persistence.Contexts;
using Reservation.Persistence.IRepositories;

namespace Reservation.Persistence.Repositories
{
    public class NailServiceRepository : INailServiceRepository
    {
        private readonly ReservationContext context;
        public NailServiceRepository(ReservationContext context)
        {
            this.context = context;
        }

        public int Add(NailService nailService)
        {
            context.Add(nailService);
            return context.SaveChanges();
        }

        public IQueryable<NailService> GetAll()
        {
            return context.NailService;
        }

        public IQueryable<NailService> GetById(int id)
        {
            return context.NailService.Where(x => x.Id == id);
        }

        public int Delete(int id)
        {
            context.Remove(id);
            return context.SaveChanges();
        }

        public IQueryable<NailService> SearchByName(string name)
        {
            return context.NailService.Where(x => x.ServiceName == name);
        }

        public int Update(NailService nailService)
        {
            context.Update(nailService);
            return context.SaveChanges();
        }
    }

}
