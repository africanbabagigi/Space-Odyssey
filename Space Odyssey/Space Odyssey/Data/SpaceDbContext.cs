using Microsoft.EntityFrameworkCore;
using Space_Odyssey.Models;
using System.Drawing;
using System.Reflection;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MissionAstronautRole>().HasKey(mar => new { mar.AstronautRoleId, mar.AstronautId, mar.MissionId });
        }
    }
}
