using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Reservation.Infrastructure.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.InfraStructure.Contexts
{
    public class DesignTimeContextFactory : IDesignTimeDbContextFactory<ReservationContext>
    {
        public ReservationContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ReservationContext>();
            builder.UseSqlServer("data source=.; initial catalog=Reservation; integrated security = true;");

            return new ReservationContext(builder.Options);
        }
    }
}
