using Reservation.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Reservation.Infrastructure.EFConfigurations
{
    public class ReservationDetailConfiguration : IEntityTypeConfiguration<ReservationDetail>
    {
        public void Configure(EntityTypeBuilder<ReservationDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
            builder.Property(x => x.ServiceNameUnitPrice).IsRequired();
            builder.Property(x => x.DesignNailUnitPrice).IsRequired();
           
        }
    }
}
