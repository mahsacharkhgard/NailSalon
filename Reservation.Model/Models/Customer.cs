namespace Reservation.Model.Models
{
    public class Customer : BaseEntity<int>
    { 
        public Customer()
        {
            Reserves = new HashSet<Reserve>();
        }
        public string UserName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public ICollection<Reserve> Reserves { get; set; }
    }
}
