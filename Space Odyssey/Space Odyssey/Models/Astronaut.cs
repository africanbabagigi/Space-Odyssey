using Microsoft.VisualBasic;

namespace Space_Odyssey.Models
{
    public class Astronaut
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Sirname { get; set; }
        public DateFormat BirthDate { get; set; }
        public string PictureUrl { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<MissionAstronautRole> MissionAstronautRoles { get; set; }
    }

}
