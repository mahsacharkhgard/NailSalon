using Reservation.Application.Contract.Commons;

namespace Reservation.Application.Contract.Dtos.NailServices
{
    public record NailServiceDto
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public int UnitPrice { get; set; }

        private string? imagePath;
        public string ImagePath
        {
            get
            {
                return ImagePathProvider.HttpImagePath + imagePath;
            }
            set
            {
                imagePath = value;
            }
        }
    }
}
