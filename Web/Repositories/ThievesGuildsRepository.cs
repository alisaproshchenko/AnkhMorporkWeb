using System.Collections.Generic;
using System.Linq;
using Web.Contexts;
using Web.Models;

namespace Web.Repositories
{
    public class ThievesGuildsRepository : IRepository<ThievesGuild>
    {
        private readonly AnkhMorporkContext _db;

        public ThievesGuildsRepository(AnkhMorporkContext db)
        {
            _db = db;
        }

        public IEnumerable<ThievesGuild> GetAll()
        {
            return _db.ThievesGuilds;
        }

        public ThievesGuild Get(int id)
        {
            return _db.ThievesGuilds.First(x => x.Id == id);
        }
    }
}