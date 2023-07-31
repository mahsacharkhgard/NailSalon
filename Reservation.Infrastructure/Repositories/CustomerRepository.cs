using Reservation.Infrastructure.Contexts;
using Reservation.Infrastructure.IRepositories;
using Reservation.Model.Models;

namespace Reservation.Infrastructure.Repositories
{
    public class CustomerRepository : BaseRepository<Customer, int>, ICustomerRepository
    {
        public CustomerRepository(ReservationContext context) : base(context)
        {

        }
    }
}
