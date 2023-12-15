using Microsoft.VisualBasic;

namespace Space_Odyssey.Models
{
    public class Mission
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateFormat StartDate { get; set; }
        public int DurationHours { get; set; }
        public int DurationMinutes { get; set; }
        public int MaximumDistanceKM { get; set; }
        public int SpaceshipId { get; set; }
        public Spaceship Spaceship { get; set; }
        public ICollection<MissionAstronautRole> MissionAstronautRoles { get; } = new List<MissionAstronautRole>();
    }
}
