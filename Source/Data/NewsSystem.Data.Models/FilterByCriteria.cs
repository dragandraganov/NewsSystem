using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSystem.Data.Models
{
    public enum FilterByCriteria
    {
        [Display(Name = "Most published news")]
        MostPublished,

        [Display(Name = "Most read news")]
        MostRead,

        [Display(Name = "Longest news")]
        Longest,

        [Display(Name = "Shortest news")]
        Shortest,

        [Display(Name = "The most updated news")]
        MostUpdated,

        [Display(Name = "Top category news")]
        MostInCategory
    }
}
