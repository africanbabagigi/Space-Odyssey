using System.ComponentModel.DataAnnotations;

namespace Space_Odyssey.Models
{
    public class Manifacturer
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Spaceship> Spaceships { get; } = new List<Spaceship>();
    }
}
