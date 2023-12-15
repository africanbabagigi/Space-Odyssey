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
    }
}
