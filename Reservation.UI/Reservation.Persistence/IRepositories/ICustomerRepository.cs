using Reservation.Model.Models;

namespace Reservation.Persistence.IRepositories
{
    public interface ICustomerRepository
    {
        int Add(Customer customer);
        int Delete(int id);
        int Update(Customer customer);
        IQueryable<Customer> GetAll();
        IQueryable<Customer> GetById(int id);
        IQueryable<Customer> SearchByKeyWord(string keyword);
    }
}
