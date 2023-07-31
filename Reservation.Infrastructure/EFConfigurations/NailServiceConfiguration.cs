using Reservation.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Reservation.Infrastructure.EFConfigurations
{
    public class NailServiceConfiguration : IEntityTypeConfiguration<NailService>
    {
        public void Configure(EntityTypeBuilder<NailService> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.ServiceName).IsRequired().HasMaxLength(128);
            builder.Property(x => x.UnitPrice).IsRequired();
        }
    }
}
