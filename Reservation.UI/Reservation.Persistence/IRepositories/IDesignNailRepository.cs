using Reservation.Model.Models;

namespace Reservation.Persistence.IRepositories
{
    public interface IDesignNailRepository
    {
        int Add(DesignNail designNail);
        int Delete(int id);
        int Update(DesignNail designNail);
        IQueryable<DesignNail> GetAll();
        IQueryable<DesignNail> GetById(int id);
        IQueryable<DesignNail> SearchByKeyWord(string keyword);
    }
}
