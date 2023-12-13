namespace Space_Odyssey.Models
{
    public class Spaceship
    {
        //TODO: Add picture 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int ManifacturerId { get; set; }
        public Manifacturer Manifacturer { get; set; }
        public ICollection<Mission> Missions { get; } = new List<Mission>();
    }
}
