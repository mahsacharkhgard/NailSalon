namespace Reservation.Model.Models
{
    public class TimeSheet : BaseEntity<int>
    {
        public DateTime TimeWork { get; set; }
        public int WorkSheetId { get; set; }
        public WorkSheet WorkSheet { get; set; }
    }
}
