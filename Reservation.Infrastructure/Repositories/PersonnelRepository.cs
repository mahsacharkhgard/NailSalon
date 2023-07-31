using Reservation.Infrastructure.Contexts;
using Reservation.Infrastructure.IRepositories;
using Reservation.Model.Models;

namespace Reservation.Infrastructure.Repositories
{
    public class PersonnelRepository : BaseRepository<Personnel, int>, IPersonnelRepository
    {
        public PersonnelRepository(ReservationContext context) : base(context) { }

    }
}
