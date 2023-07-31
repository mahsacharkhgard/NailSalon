namespace Reservation.Model.Models
{
    public class Reserve
    {
        public Reserve()
        {
            ReservationDetails = new HashSet<ReservationDetail>();
            ModifiedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int TotalPrice { get; set; }
        public DateTime ModifiedDate { get; set; }
        public ICollection<ReservationDetail> ReservationDetails { get; set; }
    }
}
