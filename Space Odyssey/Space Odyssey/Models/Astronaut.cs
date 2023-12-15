namespace Space_Odyssey.Models
{
    public class Astronaut
    {
        //TODO: ADD PICTURE 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Sirname { get; set; }
        public DateOnly BirthDate { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Mission> Missions { get; } = new List<Mission>();
        public ICollection<AstronautRoles> AstronautRoles { get; } = new List<AstronautRoles>();
    }
}
