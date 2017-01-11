using System.Collections.Generic;

namespace mvc5bootstrap.Models
{
    public class Team
    {
        public Team()
        {
            this.PLayers = new HashSet<Player>();
        }
        public int TeamID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Player> PLayers { get; set; }
    }
}