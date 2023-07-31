namespace Reservation.Model.Models
{
    public abstract class BaseEntity<TKey> where TKey : struct
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }
        public TKey Id { get; set; }
        public string Creator { get; set; }
        public string Modifier { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
