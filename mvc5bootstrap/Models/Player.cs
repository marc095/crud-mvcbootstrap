namespace mvc5bootstrap.Models
{
    public class Player
    {
        public int PLayerID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public int? TeamID { get; set; }
        public virtual Team Team { get; set; }
    }
}