namespace Reservation.Application.Contract.Dtos.Personnels
{
    public record PersonnelAddDto
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
