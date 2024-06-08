using GlobalSolutionNET.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace GlobalSolutionNET.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Drone> Drones { get; set; }
        public DbSet<FlightLicense> FlightLicenses { get; set; }
        public DbSet<Operator> Operators { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<DroneMission> DroneMissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drone>()
                .HasOne(d => d.Operator)
                .WithMany(o => o.Drones)
                .HasForeignKey(d => d.OperatorId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<Drone>()
                .HasOne(d => d.FlightLicense)
                .WithOne(fl => fl.Drone)
                .HasForeignKey<FlightLicense>(fl => fl.DroneId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DroneMission>()
                .HasKey(dm => new { dm.DroneId, dm.MissionId });

            modelBuilder.Entity<DroneMission>()
                .HasOne(dm => dm.Drone)
                .WithMany(d => d.DroneMissions)
                .HasForeignKey(dm => dm.DroneId);

            modelBuilder.Entity<DroneMission>()
                .HasOne(dm => dm.Mission)
                .WithMany(m => m.DroneMissions)
                .HasForeignKey(dm => dm.MissionId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
