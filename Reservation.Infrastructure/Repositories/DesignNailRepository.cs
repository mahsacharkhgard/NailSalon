using Reservation.Infrastructure.Contexts;
using Reservation.Infrastructure.IRepositories;
using Reservation.Model.Models;

namespace Reservation.Infrastructure.Repositories
{
    public class DesignNailRepository : BaseRepository<DesignNail, int>, IDesignNailRepository
    {
        public DesignNailRepository(ReservationContext context) : base(context)
        {

        }
    }
}
