using Web.Contexts;
using Web.Models;
using Web.Repositories;

namespace Web
{
    public class UnitOfWork
    {
        private static WebApplicationContext _db;
        public UnitOfWork()
        {
            if (_db == null)
                _db = new WebApplicationContext();
            AssassinsRepository = new AssassinsRepository(_db);
            BeggarsRepository = new BeggarsRepository(_db);
            FoolsRepository = new FoolsRepository(_db);
            ThievesGuildRepository = new ThievesGuildsRepository(_db);
        }
        public IRepository<Assassin> AssassinsRepository { get; }

        public IRepository<Beggar> BeggarsRepository { get; }

        public IRepository<Fool> FoolsRepository { get; }

        public IRepository<ThievesGuild> ThievesGuildRepository { get; }
    }
}