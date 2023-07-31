using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reservation.Model.Models;
using System.Data;

namespace Reservation.Infrastructure.EFConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            builder.Property(x => x.UserName)
                .HasColumnType<string>(nameof(SqlDbType.NVarChar))
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(x => x.FirstName)
                .HasColumnType<string>(nameof(SqlDbType.NVarChar))
                .HasMaxLength(32)
                .IsRequired();

            builder.Property(x => x.LastName)
                .HasColumnType<string>(nameof(SqlDbType.NVarChar))
                .HasMaxLength(32)
                .IsRequired();
        }
    }
}
