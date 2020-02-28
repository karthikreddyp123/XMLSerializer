using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializer
{
    [Serializable]
    public class Book
    {
        public enum GenreEnum
        {
            Computer,
            Fantasy,
            Romance,
            Horror,
            [Display(Name = "Science Fiction")]
            ScienceFiction
        }
        [XmlAttribute("id")]
        public String id { get; set; }
        public String isbn { get; set; }
        public String author { get; set; }
        public String title { get; set; }
            
        public GenreEnum genre { get; set; }
        public String publisher { get; set; }
        public DateTime publish_date { get; set; }
        public String description { get; set; }
        public DateTime registration_date { get; set; }
    }
}
