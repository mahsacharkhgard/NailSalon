using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reservation.Model.Models;

namespace Reservation.Infrastructure.EFConfigurations
{
    public class DesignNailConfiguration : IEntityTypeConfiguration<DesignNail>
    {
        public void Configure(EntityTypeBuilder<DesignNail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(64);
            builder.Property(x => x.UnitPrice).IsRequired();
        }
    }
}
