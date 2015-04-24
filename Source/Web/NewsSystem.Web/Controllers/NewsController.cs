using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsSystem.Data;
using AutoMapper.QueryableExtensions;
using NewsSystem.Web.ViewModels;
using NewsSystem.Web.Infrastructure.Helpers;
using NewsSystem.Data.Models;

namespace NewsSystem.Web.Controllers
{
    public class NewsController : BaseController
    {
        public NewsController(NewsSystemData data)
            : base(data)
        {
        }

        public void Add()
        {
            var news = XmlHelpers.DeserializeXml<News>(@"D:\Projects\NewsSystem\Source\Web\NewsSystem.Web\Content\resourceXml\DataNews.xml");
            this.Data.News.Add(news);
            this.Data.SaveChanges();
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