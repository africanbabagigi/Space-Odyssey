using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Space_Odyssey.Models
{
    public class MissionAstronautRole
    {
        [ForeignKey("AstronautId")]
        public int AstronautId { get; set; }
        [ForeignKey("RoleId")]
        public int AstronautRoleId { get; set; }
        [ForeignKey("MissionId")]
        public int MissionId { get; set; }
        public Astronaut Astronaut { get; set; }
        public AstronautRole AstronautRole { get; set; } 
        public Mission Mission { get; set; } 
    }
}
