﻿namespace Space_Odyssey.Models
{
    public class AstronautRole
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<MissionAstronautRole> MissionAstronautRoles { get; set; }
    }

}
