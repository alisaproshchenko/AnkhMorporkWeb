using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Contexts;
using Web.Models;

namespace Web.Repositories
{
    public class BeggarsRepository : IRepository<Beggar>
    {
        private readonly AnkhMorporkContext _db;
        public BeggarsRepository(AnkhMorporkContext db)
        {
            _db = db;
        }
        public IEnumerable<Beggar> GetAll()
        {
            return _db.Beggars;
        }
    }
}