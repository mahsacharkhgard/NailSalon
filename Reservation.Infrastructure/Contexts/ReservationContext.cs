using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Reservation.Infrastructure.EFConfigurations;
using Reservation.Model.IdentityModels;
using Reservation.Model.Models;

namespace Reservation.Infrastructure.Contexts
{
    public class ReservationContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>, ApplicationUserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public ReservationContext(DbContextOptions<ReservationContext> option) : base(option) { }

        public DbSet<NailService> NailService { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Personnel> Personnel { get; set; }
        public DbSet<DesignNail> DesignNail { get; set; }
        public DbSet<TimeSheet> TimeSheet { get; set; }
        public DbSet<DateSheet> DateSheet { get; set; }
        public DbSet<WorkSheet> WorkSheet { get; set; }
        public DbSet<Reserve> Reserve { get; set; }
        public DbSet<ReservationDetail> ReservationDetail { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().HasKey(x => x.Id);
            modelBuilder.Entity<ApplicationUser>().HasMany(x => x.ApplicationUserRoles).WithOne(x => x.User).HasForeignKey(x => x.UserId);

            modelBuilder.Entity<ApplicationRole>().ToTable("AspNetRoles");
            modelBuilder.Entity<ApplicationRole>().HasKey(x => x.Id);
            modelBuilder.Entity<ApplicationRole>().HasMany(x => x.ApplicationUserRoles).WithOne(x => x.Role).HasForeignKey(x => x.RoleId);

            modelBuilder.Entity<ApplicationUserRole>().HasOne(x => x.User);
            modelBuilder.Entity<ApplicationUserRole>().HasOne(x => x.Role);



            modelBuilder.Ignore<IdentityUserClaim<string>>();
            modelBuilder.Ignore<IdentityRoleClaim<string>>();
            modelBuilder.Ignore<IdentityUserToken<string>>();
            GenerateRoleData(modelBuilder);

            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new PersonnelConfiguration());
            modelBuilder.ApplyConfiguration(new TimeSheetConfiguration());
            modelBuilder.ApplyConfiguration(new DateSheetConfiguration());
            modelBuilder.ApplyConfiguration(new ReserveConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationDetailConfiguration());
            modelBuilder.ApplyConfiguration(new StatusConfiguration());
            modelBuilder.ApplyConfiguration(new NailServiceConfiguration());
            modelBuilder.ApplyConfiguration(new DesignNailConfiguration());
            modelBuilder.ApplyConfiguration(new WorkSheetConfiguration());
        }

        private static void GenerateRoleData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationRole>().HasData(
            new ApplicationRole
            {
                Id = RoleSeedData.RoleId,
                Name = RoleSeedData.Name,
                NormalizedName = RoleSeedData.NormalizedName,
                ConcurrencyStamp = RoleSeedData.ConcurrencyStamp
            },
            new IdentityRole
            {
                Id = RoleSeedData.AdminRoleId,
                Name = RoleSeedData.AdminName,
                NormalizedName = RoleSeedData.AdminNormalizedName,
                ConcurrencyStamp = RoleSeedData.AdminConcurrencyStamp
            });
        }
    }
}
