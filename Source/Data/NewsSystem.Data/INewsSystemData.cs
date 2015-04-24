using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Data
{
    public interface INewsSystemData
    {
        DbContext Context { get; }

        //IRepository<News> News { get; }

        void Dispose();

        int SaveChanges();
    }
}
