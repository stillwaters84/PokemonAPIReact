namespace Pokemon1.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Base_Experience { get; set; }
        public int Height { get; set; }
        public bool IsDefault { get; set; }
        public int Order { get; set; }
        public int Weight { get; set; }
        public string Location_Area_Encounters { get; set; }
        public Pokemon() 
        { 
            Id = 0;
            Name = "Pikachu";
            Location_Area_Encounters = "None";
        }
    }
}
