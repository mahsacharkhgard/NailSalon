namespace Reservation.Model.Models
{
    public class Customer
    {
        public Customer()
        {
            Reserves = new HashSet<Reserve>();
        }
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public ICollection<Reserve> Reserves { get; set; }

    }
}
