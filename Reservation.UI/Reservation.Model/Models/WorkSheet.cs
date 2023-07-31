namespace Reservation.Model.Models
{
    public class WorkSheet
    {
        public WorkSheet()
        {
            DateSheets = new HashSet<DateSheet>();
            TimeSheets = new HashSet<TimeSheet>();
        }
        public int Id { get; set; }
        public int DateSheetId { get; set; }
        public int TimeSheetId { get; set; }
        public ICollection<DateSheet>? DateSheets { get; set; }
        public ICollection<TimeSheet>? TimeSheets { get; set; }
    }
}
