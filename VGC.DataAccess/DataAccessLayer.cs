using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VGC.DomainModel;

namespace VGC.DataAccess
{
    public class DataAccessLayer
    {
        DataContext _context;

        public DataAccessLayer()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());

            _context = new DataContext();
        }

        public IList<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public IList<Game> GetAllGames()
        {
            return _context.Games.ToList();
        }

        public IList<Game> GetGamesForPlatform(Int32 platformId)
        {
            return _context.Games.Where(g => g.PlatformId == platformId).ToList();
        }

        public Game AddGame(Game game)
        {
            return _context.Games.Add(game);
        }
    }
}
