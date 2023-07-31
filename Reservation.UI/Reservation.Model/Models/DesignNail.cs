namespace Reservation.Model.Models
{
    public class DesignNail
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int UnitPrice { get; set; }
        public int NailServiceId { get; set; }
        public string ServiceName { get; set; }

    }
}
