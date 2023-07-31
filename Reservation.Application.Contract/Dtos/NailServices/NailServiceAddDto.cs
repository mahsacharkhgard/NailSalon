using Microsoft.AspNetCore.Http;

namespace Reservation.Application.Contract.Dtos.NailServices
{
    public record NailServiceAddDto
    {
        public string ServiceName { get; set; } = null!;
        public int UnitPrice { get; set; }
        public IFormFile Image { get; set; }
    }
}
