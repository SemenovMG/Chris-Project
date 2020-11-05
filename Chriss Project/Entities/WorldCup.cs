using System.Collections.Generic;

namespace Chriss_Project.Entities
{
    public class WorldCup
    {
        public long Id { get; set; }

        public int Year { get; set; }
        public string Description { get; set; }

        public Country Host { get; set; }
        public List<Team> Teams { get; set; }
        public Team Champion { get; set; }
    }
}
