using Reservation.Model.Models;

namespace Reservation.Persistence.IRepositories
{
    public interface IPersonnelRepository
    {
        int Add(Personnel personnel);
        int Delete(int id);
        int Update(Personnel personnel);
        IQueryable<Personnel> GetAll();
        IQueryable<Personnel> GetById(int id);
        IQueryable<Personnel> SearchByKeyWord(string keyword);
    }
}
