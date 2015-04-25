using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace NewsSystem.Data.Models
{
    public enum GraphCriteria
    {
        [Display(Name = "Most published news")]
        MostPublished,

        [Display(Name = "Most read news")]
        MostRead,

        [Display(Name = "News by Category")]
        ByCategory,
    }
}
