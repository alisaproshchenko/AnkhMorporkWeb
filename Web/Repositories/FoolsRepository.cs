﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Contexts;
using Web.Models;

namespace Web.Repositories
{
    public class FoolsRepository : IRepository<Fool>
    {
        private readonly AnkhMorporkContext _db;

        public FoolsRepository(AnkhMorporkContext db)
        {
            _db = db;
        }

        public IEnumerable<Fool> GetAll()
        {
            return _db.Fools;
        }
    }
}