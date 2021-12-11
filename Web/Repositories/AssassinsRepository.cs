using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Contexts;
using Web.Models;

namespace Web.Repositories
{
    public class AssassinsRepository : IRepository<Assassin>
    {
        private readonly AnkhMorporkContext _db;
        public AssassinsRepository(AnkhMorporkContext db)
        {
            _db = db;
        }
        public IEnumerable<Assassin> GetAll()
        {
            return _db.Assassins;
        }
    }
}