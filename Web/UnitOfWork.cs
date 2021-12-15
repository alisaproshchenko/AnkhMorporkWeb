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
        public UnitOfWork()
        {
            AssassinsRepository = new AssassinsRepository();
            BeggarsRepository = new BeggarsRepository();
            FoolsRepository = new FoolsRepository();
            ThievesGuildRepository = new ThievesGuildsRepository();
        }
        public IRepository<Assassin> AssassinsRepository { get; }

        public IRepository<Beggar> BeggarsRepository { get; }

        public IRepository<Fool> FoolsRepository { get; }

        public IRepository<ThievesGuild> ThievesGuildRepository { get; }
    }
}