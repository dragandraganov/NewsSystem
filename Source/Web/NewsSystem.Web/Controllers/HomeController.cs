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
        public ActionResult Index(string query, DateTime? startDate, DateTime? endDate, string criteria)
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

                allNews = allNews.Where(t => t.PubDate >= startDate && t.PubDate <= endDate);
            }

            if (!(criteria == null || criteria.Trim() == String.Empty))
            {
                switch (criteria)
                {
                    case "0":
                        allNews = allNews.OrderByDescending(n => n.CountPublications);
                        break;
                    case "1":
                        allNews = allNews.OrderByDescending(n => n.CountVisits);
                        break;
                    case "2":
                        allNews = allNews.OrderByDescending(n => n.Description.Length);
                        break;
                    case "3":
                        allNews = allNews.OrderBy(n => n.Description.Length);
                        break;
                    case "4":
                        allNews = allNews.OrderByDescending(n => n.CountUpdates);
                        break;
                    case "5":
                        var topCategory = allNews.GroupBy(n => n.Category).OrderByDescending(c => c.Count()).First().Key;
                        allNews = allNews.Where(n => n.Category == topCategory);
                        break;
                    default:
                        break;
                }
            }

            var allTasksModel = allNews.Project()
                .To<NewsViewModel>()
                .ToList();

            return View(allTasksModel);
        }
    }
}