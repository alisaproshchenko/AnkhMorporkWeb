using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using Web.Contexts;
using Web.Models;
using Web.Repositories;

namespace Web
{
    public class UnitOfWork
    {
        private AnkhMorporkContext _context;
        private IRepository<Assassin> _assassinsRepository;
        private IRepository<Beggar> _beggarsRepository;
        private IRepository<Fool> _foolsRepository;
        private IRepository<ThievesGuild> _thievesGuildRepository;

        public UnitOfWork()
        {
            _context = new AnkhMorporkContext();
            _assassinsRepository = new AssassinsRepository(_context);
            _beggarsRepository = new BeggarsRepository(_context);
            _foolsRepository = new FoolsRepository(_context);
            _thievesGuildRepository = new ThievesGuildsRepository(_context);
        }
        public IRepository<Assassin> AssassinsRepository => _assassinsRepository;
        public IRepository<Beggar> BeggarsRepository => _beggarsRepository;
        public IRepository<Fool> FoolsRepository => _foolsRepository;
        public IRepository<ThievesGuild> ThievesGuildRepository => _thievesGuildRepository;
    }
}