using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace XMLSerializer
{
    [Serializable]
    public class Book:ISerializable
    {
        //Enumeration for Genre
        public enum Genres
        {
            Computer,
            Fantasy,
            Romance,
            Horror,
            [XmlEnum("Science Fiction")]
            [Description("Science Fiction")]
            ScienceFiction
        }
        [XmlAttribute("id")]
        public String Id { get; set; }

        [XmlElement("isbn")]
        public String ISBN { get; set; }

        [XmlElement("author")]
        public String Author { get; set; }

        [XmlElement("title")]
        public String Title { get; set; }

        [XmlElement("genre")]
        public Genres Genre { get; set; }

        [XmlElement("publisher")]
        public String Publisher { get; set; }

        [XmlElement("publish_date")]
        public DateTime PublishDate { get; set; }

        [XmlElement("description")]
        public String Description { get; set; }

        [XmlElement("registration_date")]
        public DateTime RegistrationDate { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("ISBN", ISBN);
            info.AddValue("Author", Author);
            info.AddValue("Title", Title);
            info.AddValue("Genre", Genre);
            info.AddValue("Publisher", Publisher);
            info.AddValue("PublishDate", String.Format("{0:dd-MM-yyyy}", PublishDate));
            info.AddValue("Description", Description);
            info.AddValue("RegistrationDate", String.Format("{0:dd-MM-yyyy}", RegistrationDate));
        }
    }
}
