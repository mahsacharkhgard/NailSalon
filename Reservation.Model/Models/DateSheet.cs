namespace Reservation.Model.Models
{
    public class DateSheet : BaseEntity<int>
    {
        public DateTime DateWork { get; set; }
        public int WorkSheetId { get; set; }
        public WorkSheet WorkSheet { get; set; }
    }
}
