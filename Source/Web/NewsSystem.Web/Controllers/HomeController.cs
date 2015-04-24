using NewsSystem.Data;
using System;
using System.Linq;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using NewsSystem.Web.ViewModels;

namespace NewsSystem.Web.Controllers
{
    public class HomeController : BaseController
    {

        public HomeController(NewsSystemData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            var news = this.Data.News
                .All()
                .Project()
                .To<NewsViewModel>();
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