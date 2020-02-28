using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializer
{
    [Serializable]
    [XmlRoot("catalog",Namespace = "http://library.by/catalog")]
    public class Catalog
    {
        [XmlAttribute("date")]
        public DateTime Date { get; set; }
        [System.Xml.Serialization.XmlElement("book")]
        public Book[] book { get; set; }
    }
}
