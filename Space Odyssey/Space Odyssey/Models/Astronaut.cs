namespace Space_Odyssey.Models
{
    public class Astronaut
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Sirname { get; set; }
        public DateOnly BirthDate { get; set; }
        public string PictureUrl { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Mission> Missions { get; } = new List<Mission>();
        public ICollection<AstronautRole> AstronautRoles { get; } = new List<AstronautRole>();
    }
}
