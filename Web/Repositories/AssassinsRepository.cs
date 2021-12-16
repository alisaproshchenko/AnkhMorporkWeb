using System.Collections.Generic;
using System.Linq;
using Web.Contexts;
using Web.Models;

namespace Web.Repositories
{
    public class AssassinsRepository : IRepository<Assassin>
    {
        private static AssassinsContext _db;
        public AssassinsRepository()
        {
            if (_db == null)
                _db = new AssassinsContext();
        }
        public IEnumerable<Assassin> GetAll()
        {
            return _db.Assassins;
        }

        public Assassin Get(int id)
        {
            return _db.Assassins.FirstOrDefault(x => x.Id == id);
        }
        public Assassin FindAssassin(decimal payment)
        {
            return _db.Assassins.FirstOrDefault(x => !x.Busy && x.RewardMin <= payment && x.RewardMax >= payment);
        }
        public decimal GetMinReward()
        {
            var selected = from x in _db.Assassins
                where !x.Busy
                select x.RewardMin;
            return selected.Min();
        }
    }
}