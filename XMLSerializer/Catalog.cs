using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace XMLSerializer
{
    [Serializable]
    [XmlRoot("catalog", Namespace = "http://library.by/catalog")]
    public class Catalog: ISerializable
    {
        [XmlAttribute("date")]
        public DateTime Date { get; set; }
        [System.Xml.Serialization.XmlElement("book")]
        public Book[] Book { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Date", Date);
            info.AddValue("Book", Book);
        }
    }
}