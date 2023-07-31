using Reservation.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Reservation.Infrastructure.EFConfigurations
{
    internal class PersonnelConfiguration : IEntityTypeConfiguration<Personnel>
    {
        public void Configure(EntityTypeBuilder<Personnel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(11);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(32);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(32);
        }

    }
}
