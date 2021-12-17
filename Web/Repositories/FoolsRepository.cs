using System.Collections.Generic;
using System.Linq;
using Web.Contexts;
using Web.Models;

namespace Web.Repositories
{
    public class FoolsRepository : IRepository<Fool>
    {
        private static WebApplicationContext _db;
        public FoolsRepository(WebApplicationContext db)
        {
            if (_db == null)
                _db = db;
        }

        public IEnumerable<Fool> GetAll()
        {
            return _db.Fools;
        }

        public Fool Get(int id)
        {
            return _db.Fools.FirstOrDefault(x => x.Id == id);
        }
    }
}