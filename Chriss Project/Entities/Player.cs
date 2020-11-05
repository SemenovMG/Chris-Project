using System.Collections.Generic;

namespace Chriss_Project.Entities
{
    public enum Role
    {
        Bowler,
        Batsman,
        Wicketkeeper,
        Captain
    }
    public class Player
    {
        public long Id { get; set; }

        public Country Country { get; set; }
        public List<TeamPlayer> TeamPlayers { get; set; } 
        public string Name { get; set; }
        public Role Role { get; set; }
    }
}
