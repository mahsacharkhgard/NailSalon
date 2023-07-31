using Reservation.Infrastructure.Contexts;
using Reservation.Infrastructure.IRepositories;
using Reservation.Model.Models;

namespace Reservation.Infrastructure.Repositories
{
    public class NailServiceRepository : BaseRepository<NailService, int>, INailServiceRepository
    {
        public NailServiceRepository(ReservationContext context) : base(context)
        {

        }
    }

}
