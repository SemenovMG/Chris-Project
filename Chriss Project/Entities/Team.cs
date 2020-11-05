using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chriss_Project.Entities
{
    public class Team
    {
        public long Id { get; set; }

        public int Year { get; set; }

        public List<TeamPlayer> TeamPlayers { get; set; }
        public Country Country { get; set; }
    }
}
