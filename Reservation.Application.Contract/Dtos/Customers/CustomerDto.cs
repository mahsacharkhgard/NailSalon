namespace Reservation.Application.Contract.Dtos.Customers
{
    public record CustomerDto
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
