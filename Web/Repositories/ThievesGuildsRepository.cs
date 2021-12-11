using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    }
}