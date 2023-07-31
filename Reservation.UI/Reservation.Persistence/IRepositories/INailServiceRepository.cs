using Reservation.Model.Models;

namespace Reservation.Persistence.IRepositories
{
    public interface INailServiceRepository
    {
        int Add(NailService nailService);
        int Delete(int id);
        int Update(NailService nailService);
        IQueryable<NailService> GetAll();
        IQueryable<NailService> GetById(int id);
        IQueryable<NailService> SearchByName(string name);
    }
}
