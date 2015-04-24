using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace NewsSystem.Data.Models
{
    [XmlRoot("stream")]
    public class News
    {
        public News()
        {
            this.PubDate = DateTime.Now;
            this.CountPublications = 1;
        }

        [Key]
        public int Id { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        //TODO set length and uncomment the row bellow
        //[Index(IsUnique = true)]
        [XmlElement("link")]
        public string Link { get; set; }

        [XmlElement("category")]
        public Category Category { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlIgnore()]
        public DateTime PubDate { get; set; }

        [XmlElement("pubDate")]
        [NotMapped]
        public string Time
        {
            get { return XmlConvert.ToString(this.PubDate, XmlDateTimeSerializationMode.RoundtripKind); }
            set { this.PubDate = DateTime.ParseExact(value, "MM-dd-yyyy", CultureInfo.InvariantCulture); }
        }

        public int CountVisits { get; set; }

        public int CountPublications { get; set; }

        public int CountUpdates { get; set; }
    }
}
