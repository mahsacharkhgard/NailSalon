using Reservation.Model.Models;
using Reservation.Persistence.Contexts;
using Reservation.Persistence.IRepositories;
using System.Data;

namespace Reservation.Persistence.Repositories
{
    public class PersonnelRepository : IPersonnelRepository
    {
        private readonly ReservationContext context;
        public PersonnelRepository(ReservationContext context)
        {
            this.context = context;
        }
        public int Add(Personnel personnel)
        {
            context.Personnel.Add(personnel);
            return context.SaveChanges();
        }
        public IQueryable<Personnel> GetAll()
        {
            return context.Personnel;
        }

        public IQueryable<Personnel> GetById(int id)
        {
            return context.Personnel.Where(x => x.Id == id);
        }

        public int Delete(int id)
        {
            context.Remove(id);
            return context.SaveChanges();
        }

        public IQueryable<Personnel> SearchByKeyWord(string keyword)
        {
            return context.Personnel.Where(x => x.FirstName == keyword);
        }

        public int Update(Personnel personnel)
        {
            context.Personnel.Update(personnel);
            return context.SaveChanges();
        }
    }
}
