namespace Reservation.Application.Contract.Dtos.DesignNails
{
    public record DesignNailDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int UnitPrice { get; set; }
    }
}
