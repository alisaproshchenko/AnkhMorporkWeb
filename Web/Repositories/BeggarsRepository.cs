using System.Collections.Generic;
using System.Linq;
using Web.Contexts;
using Web.Models;

namespace Web.Repositories
{
    public class BeggarsRepository : IRepository<Beggar>
    {
        private static WebApplicationContext _db;
        public BeggarsRepository(WebApplicationContext db)
        {
            if (_db == null)
                _db = db;
        }
        public IEnumerable<Beggar> GetAll()
        {
            return _db.Beggars;
        }

        public Beggar Get(int id)
        {
            return _db.Beggars.FirstOrDefault(x => x.Id == id);
        }
    }
}