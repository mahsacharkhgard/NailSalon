namespace Reservation.Model.Models
{
    public class ReservationDetail
    {
        public ReservationDetail()
        {
            WorkSheets = new HashSet<WorkSheet>();
            NailServices = new HashSet<NailService>();
        }
        
        public Reserve Reserve { get; set; }
        public int PersonnelId { get; set; }
        public Personnel Personnel { get; set; }
        public int NailServiceId { get; set; }
        public string ServiceName { get; set; }
        public int ServiceNameUnitPrice { get; set; }
        public int DesignNailId { get; set; }
        public int DesignNailUnitPrice { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public ICollection<WorkSheet>? WorkSheets { get; set; }
        public ICollection<NailService> NailServices { get; set; }
        
    }
}
