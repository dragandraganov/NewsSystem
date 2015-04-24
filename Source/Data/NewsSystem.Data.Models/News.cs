using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace NewsSystem.Data.Models
{
    public class News
    {
        public News()
        {
            this.CreatedOn = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        [Index(IsUnique=true)]
        public string Link { get; set; }

        public Category Category { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CountVisits { get; set; }

        public int CountPublications { get; set; }

        public int CountUpdates { get; set; }
    }
}
