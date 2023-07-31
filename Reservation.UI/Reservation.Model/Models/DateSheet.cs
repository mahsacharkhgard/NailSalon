namespace Reservation.Model.Models
{
    public class DateSheet
    {
        public int Id { get; set; }
        public DateTime DateWork { get; set; }
        public int WorkSheetId { get; set; }
        public WorkSheet WorkSheet { get; set; }
    }
}
