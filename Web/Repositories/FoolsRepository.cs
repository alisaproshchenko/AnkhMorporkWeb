using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Contexts;
using Web.Models;

namespace Web.Repositories
{
    public class FoolsRepository : IRepository<Fool>
    {
        private static FoolsContext _db;

        public FoolsRepository()
        {
            if (_db == null)
                _db = new FoolsContext();
        }

        public IEnumerable<Fool> GetAll()
        {
            return _db.Fools;
        }

        public Fool Get(int id)
        {
            return _db.Fools.First(x => x.Id == id);
        }
    }
}