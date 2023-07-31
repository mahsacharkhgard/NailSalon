namespace Reservation.Model.Models
{
       
    public class Reserve : BaseEntity<int>
    {
        public Reserve()
        {
            ReservationDetails = new HashSet<ReservationDetail>();
           
        }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int TotalPrice { get; set; }
        public ICollection<ReservationDetail> ReservationDetails { get; set; }    
    }
}
