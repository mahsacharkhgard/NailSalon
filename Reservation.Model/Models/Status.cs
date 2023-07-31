namespace Reservation.Model.Models
{
    public class Status : BaseEntity<int>
    {
        public string Name { get; set; } = null!;
        public ICollection<ReservationDetail> ReservationDetails { get; set; }
    }
}
