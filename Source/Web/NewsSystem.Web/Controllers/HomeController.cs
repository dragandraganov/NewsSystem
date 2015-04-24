using NewsSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private NewsSystemDbContext db;

        public HomeController()
        {
            this.db = new NewsSystemDbContext();
        }

        public ActionResult Index()
        {
            var news = this.db.News;
            return View(news);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}