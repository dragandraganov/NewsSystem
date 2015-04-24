using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsSystem.Data;
using AutoMapper.QueryableExtensions;
using NewsSystem.Web.ViewModels;

namespace NewsSystem.Web.Controllers
{
    public class NewsController : BaseController
    {
        public NewsController(NewsSystemData data)
            : base(data)
        {
        }

        // GET: News
        public ActionResult Details(int id)
        {
            var news = this.Data.News
                .All()
                .Project()
                .To<NewsViewModel>()
                .FirstOrDefault(n => n.Id == id);
            return View(news);
        }
    }
}