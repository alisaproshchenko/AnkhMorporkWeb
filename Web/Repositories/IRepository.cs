using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}