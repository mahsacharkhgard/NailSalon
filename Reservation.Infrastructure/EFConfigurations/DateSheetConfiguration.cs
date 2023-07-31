using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reservation.Model.Models;

namespace Reservation.Infrastructure.EFConfigurations
{
    public class DateSheetConfiguration : IEntityTypeConfiguration<DateSheet>
    {
        public void Configure(EntityTypeBuilder<DateSheet> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.DateWork).IsRequired();
        }
    }
}
