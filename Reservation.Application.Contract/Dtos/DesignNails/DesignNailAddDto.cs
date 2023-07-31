namespace Reservation.Application.Contract.Dtos.DesignNails
{
    public record DesignNailAddDto
    {
        public string Name { get; set; } = null!;
        public int UnitPrice { get; set; }
    }
}
