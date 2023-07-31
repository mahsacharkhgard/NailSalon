using Reservation.Model.Models;
using Reservation.Persistence.Contexts;
using Reservation.Persistence.IRepositories;

namespace Reservation.Persistence.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ReservationContext context;
        public CustomerRepository(ReservationContext context)
        {
            this.context = context;
        }

        public int Add(Customer customer)
        {
            context.Add(customer);
            return context.SaveChanges();
        }

        public IQueryable<Customer> GetAll()
        {
            return context.Customer;
        }

        public IQueryable<Customer> GetById(int id)
        {
            return context.Customer.Where(x => x.Id == id);
        }

        public int Delete(int id)
        {
            context.Remove(id);
            return context.SaveChanges();
        }

        public IQueryable<Customer> SearchByKeyWord(string keyword)
        {
            return context.Customer.Where(x => x.FirstName == keyword);
        }

        public int Update(Customer customer)
        {
            context.Update(customer);
            return context.SaveChanges();
        }
    }
}
