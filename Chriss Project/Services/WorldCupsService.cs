using Chriss_Project.Entities;
using Chriss_Project.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Chriss_Project.Services
{
    public class WorldCupsService : IWorldCupsService
    {
        //public readonly List<WorldCup> worldCups;
        private readonly DataContext db;
        public WorldCupsService(DataContext _db)
        {
            db = _db;
            /*
            worldCups = new List<WorldCup>();

            Country england = new Country
            {
                Name = "England",
                Flag = "https://www.countryflags.io/GB/shiny/64.png"
            };
            Country westIndies = new Country
            {
                Name = "West Indies",
                Flag = "https://upload.wikimedia.org/wikipedia/en/6/65/West_indies_cricket_board_flag.png"
            };

            Team WestIndies = new Team
            {
                Year = 1975,
                Country = westIndies
            };

            worldCups.Add(new WorldCup
            {
                Year = 1975,
                Host = england,
                Champion = WestIndies,
                Description = "First World Cup",
                Teams = new List<Team>()
            });

            worldCups.Add(new WorldCup
            {
                Year = 1979,
                Host = england,
                Champion = WestIndies,
                Description = "Second World Cup",
                Teams = new List<Team>()
            });
            */
        }

        public List<WorldCup> GetWorldCups()
        {
            return db.WorldCups
                .Include(wc => wc.Champion)
                    .ThenInclude(c => c.Country)
                .ToList();
        }

    }
}
