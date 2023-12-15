using System.ComponentModel.DataAnnotations.Schema;

namespace Space_Odyssey.Models
{
    public class MissionAstronautRole
    {
        public int AstronautId { get; set; }
        public int RoleId { get; set; }
        public int MissionId { get; set; }
        public Astronaut Astronaut { get; set; } = null!;
        public AstronautRole AstronautRole { get; set; } = null!;
        public Mission Mission { get; set; } = null!;
    }
}
