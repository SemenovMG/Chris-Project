using Chriss_Project.Entities;
using Microsoft.EntityFrameworkCore;


namespace Chriss_Project.Persistence
{
    public class DataContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<WorldCup> WorldCups { get; set; }


        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }


    }
}
