using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reservation.Model.Models;

namespace Reservation.Infrastructure.EFConfigurations
{
    public class ReserveConfiguration : IEntityTypeConfiguration<Reserve>
    {
        public void Configure(EntityTypeBuilder<Reserve> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.TotalPrice).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();
        }
    }
}
