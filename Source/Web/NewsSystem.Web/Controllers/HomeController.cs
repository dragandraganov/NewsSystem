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

        //TODO Use Cache
        public ActionResult Index(string query, DateTime? startDate, DateTime? endDate)
        {
            var allNews = this.Data.News
                .All();

            if (!(query == null || query.Trim() == String.Empty))
            {
                allNews = allNews.Where(n => n.Title.IndexOf(query) != -1);
            }

            if (startDate != null || endDate != null)
            {
                if (startDate == null)
                {
                    startDate = DateTime.Now;
                }
                else if (endDate == null)
                {
                    endDate = DateTime.Now;
                }
                allNews = allNews.Where(t => t.CreatedOn >= startDate && t.CreatedOn <= endDate);
            }

            var allTasksModel = allNews.Project()
                .To<NewsViewModel>()
                .ToList();

            return View(allTasksModel);
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