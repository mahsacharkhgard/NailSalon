namespace Reservation.Model.Models
{
    public class DesignNail : BaseEntity<int>
    {
        public string Name { get; set; } = null!;
        public int UnitPrice { get; set; }
        public int NailServiceId { get; set; }
        public string  ServiceName { get; set; }

    }
}
