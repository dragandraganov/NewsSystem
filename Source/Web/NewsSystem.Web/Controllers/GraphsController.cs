using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using NewsSystem.Data;

namespace NewsSystem.Web.Controllers
{
    public class GraphsController : BaseController
    {
        public GraphsController(NewsSystemData data)
            : base(data)
        {
        }

        public ActionResult Index(DateTime? startDate, DateTime? endDate, string criteria)
        {
            var chart = new Chart(width: 1200, height: 400);

            var allNews = this.Data.News.All();

            if (startDate != null || endDate != null)
            {
                if (endDate == null)
                {
                    endDate = DateTime.Now;
                }

                allNews = allNews.Where(n => n.PubDate >= startDate && n.PubDate <= endDate);
            }

            switch (criteria)
            {
                case "0":
                    var mostPublishedNews = allNews
                        .OrderByDescending(n => n.CountPublications)
                        .Take(5);

                    chart.AddTitle("Top 5 published news");

                    chart.AddSeries(
                        chartType: "Column",
                        xValue: mostPublishedNews.Select(n => n.Title).ToList(),
                        yValues: mostPublishedNews.Select(n => n.CountPublications).ToList());
                    break;

                case "1":
                    var mostReadNews = allNews
                        .OrderByDescending(n => n.CountVisits)
                        .Take(5);

                    chart.AddTitle("Top 5 visited news");

                    chart.AddSeries(
                        chartType: "Column",
                        xValue: mostReadNews.Select(n => n.Title).ToList(),
                        yValues: mostReadNews.Select(n => n.CountVisits).ToList());
                    break;

                case "2":
                    var newsGroupedByCategory = allNews
                        .GroupBy(n => n.Category)
                        .Select(gr => new 
                        { 
                            Category = gr.Key.ToString(), 
                            Count = gr.Count() 
                        })
                        .OrderBy(gr=>gr.Count);

                    chart.AddTitle("News by category");

                    chart.AddSeries(
                        chartType: "Pie",
                        xValue: newsGroupedByCategory.Select(n => n.Category).ToList(),
                        yValues: newsGroupedByCategory.Select(n => n.Count).ToList());
                    break;
                default:
                    break;
            }

            var file = chart.GetBytes("png");
            return File(file, "image/png");
        }
    }
}