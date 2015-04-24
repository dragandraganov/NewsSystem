using NewsSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Data
{
    public class NewsSystemDbContext : DbContext
    {
        public NewsSystemDbContext()
            : base("DefaultConnection")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<NewsSystemDbContext, Configuration>());
        }

        //public virtual IDbSet<News> News { get; set; }

        public static NewsSystemDbContext Create()
        {
            return new NewsSystemDbContext();
        }
    }
}
