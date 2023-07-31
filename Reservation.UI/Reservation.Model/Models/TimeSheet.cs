namespace Reservation.Model.Models
{
    public class TimeSheet
    {
        public int Id { get; set; }
        public DateTime TimeWork { get; set; }
        public int WorkSheetId { get; set; }
        public WorkSheet WorkSheet { get; set; }
    }
}
