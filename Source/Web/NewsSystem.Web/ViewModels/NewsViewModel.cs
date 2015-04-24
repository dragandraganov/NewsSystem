using AutoMapper;
using NewsSystem.Data.Models;
using NewsSystem.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsSystem.Web.ViewModels
{
    public class NewsViewModel : IMapFrom<News>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        //TODO set length and uncomment the row bellow
        //[Index(IsUnique = true)]
        public string Link { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CountVisits { get; set; }

        public int CountPublications { get; set; }

        public int CountUpdates { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<News, NewsViewModel>()
                .ForMember(m => m.CategoryName, opt => opt.MapFrom(t => t.Category.ToString()))
                .ReverseMap();
        }
    }
}