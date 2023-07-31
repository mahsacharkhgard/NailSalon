using Reservation.Model.Models;
using System.Data.Entity;


namespace Reservation.Persistence.Contexts
{
    public class ReservationContext : DbContext
    {
        public ReservationContext(/*DbContextOptions<ReservationContext> option*/) : base(/*option*/) { }
        public DbSet<NailService>? NailService { get; set; }
        public DbSet<Customer>? Customer { get; set; }
        public DbSet<Personnel>? Personnel { get; set; }
        public DbSet<DesignNail>? DesignNail { get; set; }
        public DbSet<TimeSheet>? TimeSheet { get; set; }
        public DbSet<DateSheet>? DateSheet { get; set; }
        public DbSet<WorkSheet>? WorkSheet { get; set; }
        public DbSet<Reserve>? Reserve { get; set; }
        public DbSet<ReservationDetail>? ReservationDetail { get; set; }
        public DbSet<Status>? Status { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.ApplyConfiguration(new CustomerConfiguration());
        //    modelBuilder.ApplyConfiguration(new PersonnelConfiguration());
        //    modelBuilder.ApplyConfiguration(new TimeSheetConfiguration());
        //    modelBuilder.ApplyConfiguration(new DateSheetConfiguration());
        //    modelBuilder.ApplyConfiguration(new ReserveConfiguration());
        //    modelBuilder.ApplyConfiguration(new ReservationDetailConfiguration());
        //    modelBuilder.ApplyConfiguration(new StatusConfiguration());
        //    modelBuilder.ApplyConfiguration(new NailServiceConfiguration());
        //    modelBuilder.ApplyConfiguration(new DesignNailConfiguration());
        //    modelBuilder.ApplyConfiguration(new WorkSheetConfiguration());
        //}
    }
}
