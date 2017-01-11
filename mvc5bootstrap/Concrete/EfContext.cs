using mvc5bootstrap.Models;
using System.Data.Entity;

namespace mvc5bootstrap.Concrete
{
    public class EfContext : DbContext
    {
        public EfContext() : base("BFM")
        {

        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}