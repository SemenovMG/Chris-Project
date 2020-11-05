using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chriss_Project.Entities
{
    public class TeamPlayer
    {
        public long Id { get; set; }
        public long PlayerId { get; set; }
        public long TeamId { get; set; }

        public Team Team { get; set; }
        public Player Player { get; set; }

    }
}
