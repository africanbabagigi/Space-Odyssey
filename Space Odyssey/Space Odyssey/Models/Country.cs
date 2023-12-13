using System.ComponentModel.DataAnnotations;

namespace Space_Odyssey.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required, MaxLength(56)]
        public string Name { get; set; }
        public ICollection<Manifacturer> Manifacturers { get; } = new List<Manifacturer>();
        public ICollection<Astronaut> Astronauts { get; } = new List<Astronaut>();
    }
}
