using Microsoft.EntityFrameworkCore;
using Space_Odyssey.Models;

namespace Space_Odyssey.Data
{
    public class SpaceDbContext : DbContext
    {
        public SpaceDbContext(DbContextOptions<SpaceDbContext> options)
            : base(options)
        {
        }
        DbSet<Astronaut> Astronauts { get; set; }
        DbSet<AstronautRole> AstronautRoles { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<Manifacturer> Manifacturers { get; set; }
        DbSet<Spaceship> Spaceships { get; set; }
        DbSet<Mission> Missions { get; set; }
        DbSet<MissionAstronautRole> MissionAstronautRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MissionAstronautRole>()
                .HasKey(amr => new { amr.AstronautId, amr.RoleId, amr.MissionId });

            modelBuilder.Entity<MissionAstronautRole>()
                .HasOne(amr => amr.Astronaut)
                .WithMany(a => a.MissionAstronautRoles)
                .HasForeignKey(amr => amr.AstronautId);

            modelBuilder.Entity<MissionAstronautRole>()
                .HasOne(amr => amr.AstronautRole)
                .WithMany(ar => ar.MissionAstronautRoles)
                .HasForeignKey(amr => amr.RoleId);

            modelBuilder.Entity<MissionAstronautRole>()
                .HasOne(amr => amr.Mission)
                .WithMany(m => m.MissionAstronautRoles)
                .HasForeignKey(amr => amr.MissionId);
        }
    }
}
