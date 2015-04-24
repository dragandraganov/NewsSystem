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

        //TODO: Count updates and repeated news /link is unique/
        public void AddOrUpdate()
        {
            if (!Request.IsAjaxRequest())
            {
                throw new HttpException();
            }

            var news = XmlHelpers.DeserializeXml<News>(@"D:\Projects\NewsSystem\Source\Web\NewsSystem.Web\Content\resourceXml\DataNews.xml");

            var existingNews = this.Data.News.All().FirstOrDefault(n => n.Link == news.Link);

            if (existingNews == null)
            {
                this.Data.News.Add(news);
            }

            else
            {
                if (existingNews.Description != news.Description || existingNews.Title != news.Title)
                {
                    existingNews.Description = news.Description;
                    existingNews.Title = news.Title;
                    existingNews.CountUpdates++;
                }

                existingNews.CountPublications++;
                this.Data.News.Update(existingNews);
            }

            this.Data.SaveChanges();
        }

        // GET: News
        //TODO : Count visits
        public ActionResult Details(int id)
        {
            var news = this.Data.News
                .All()
                .FirstOrDefault(n => n.Id == id);

            if (news != null)
            {
                news.CountVisits++;
                this.Data.News.Update(news);
                this.Data.SaveChanges();
            }

            var newsModel = AutoMapper.Mapper.Map<News, NewsViewModel>(news);

            return View(newsModel);
        }
    }
}