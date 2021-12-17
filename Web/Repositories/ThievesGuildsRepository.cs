using System.Collections.Generic;
using System.Linq;
using Web.Contexts;
using Web.Models;

namespace Web.Repositories
{
    public class ThievesGuildsRepository : IRepository<ThievesGuild>
    {
        private static WebApplicationContext _db;
        public ThievesGuildsRepository(WebApplicationContext db)
        {
            if (_db == null)
                _db = db;
        }

        public IEnumerable<ThievesGuild> GetAll()
        {
            return _db.ThievesGuilds;
        }

        public ThievesGuild Get(int id)
        {
            return _db.ThievesGuilds.FirstOrDefault(x => x.Id == id);
        }
    }
}