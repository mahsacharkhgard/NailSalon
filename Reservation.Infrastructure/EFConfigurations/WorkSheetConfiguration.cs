using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reservation.Model.Models;

namespace Reservation.Infrastructure.EFConfigurations
{
    public class WorkSheetConfiguration : IEntityTypeConfiguration<WorkSheet>
    {
        public void Configure(EntityTypeBuilder<WorkSheet> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.DateSheetId).IsRequired();
            builder.Property(x => x.TimeSheetId).IsRequired();
        }
    }
}
