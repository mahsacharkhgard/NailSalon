namespace Reservation.Model.Models
{
    public class NailService
    {
        public NailService()
        {
            DesignNails = new HashSet<DesignNail>();
        }
        public int Id { get; set; }
        public string ServiceName { get; set; } = null!;
        public int UnitPrice { get; set; }
        public string ImagePath { get; set; } = null!;
        public ICollection<DesignNail> DesignNails { get; set; }
    }
}
