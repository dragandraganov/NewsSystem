namespace NewsSystem.Data.Migrations
{
    using NewsSystem.Data.Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NewsSystem.Data.NewsSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(NewsSystem.Data.NewsSystemDbContext context)
        {
            context.News.Add(new News {Title="Test title", Description="Test desc", Link="www.test112233.com" });
            context.SaveChanges();
        }
    }
}
