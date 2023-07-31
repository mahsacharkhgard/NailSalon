namespace Reservation.Application.Contract.Dtos.NailServices
{
    public record SearchNailServiceRequestDto
    {
        public int Id { get; set; }
        public string ServiceName { get; set; } = null!;
        public int UnitPrice { get; set; }
    }
}
