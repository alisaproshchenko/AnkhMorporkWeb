using Web.Contexts;
using Web.Models;
using Web.Repositories;

namespace Web
{
    public class UnitOfWork
    {
        private static AnkhMorporkContext _context;

        public UnitOfWork()
        {
            if(_context == null) 
                _context = new AnkhMorporkContext();

            AssassinsRepository = new AssassinsRepository(_context);
            BeggarsRepository = new BeggarsRepository(_context);
            FoolsRepository = new FoolsRepository(_context);
            ThievesGuildRepository = new ThievesGuildsRepository(_context);
        }
        public IRepository<Assassin> AssassinsRepository { get; }

        public IRepository<Beggar> BeggarsRepository { get; }

        public IRepository<Fool> FoolsRepository { get; }

        public IRepository<ThievesGuild> ThievesGuildRepository { get; }
    }
}