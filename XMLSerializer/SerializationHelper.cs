using Newtonsoft.Json;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace XMLSerializer
{
    public class SerializationHelper
    {
        private static Catalog _BooksCatalog = null;
        public static void Main(string[] args)
        {
            XmlDeserialize();
            JsonSerialize();
        }
        /// <summary>
        /// This method Deserializes Xml data to object type. 
        /// </summary>
        private static void XmlDeserialize()
        {
            string FilePath = @"~\..\..\..\books.xml"; 
            XmlSerializer Serializer = new XmlSerializer(typeof(Catalog));
            XmlReader XmlReader = XmlReader.Create(FilePath);
            _BooksCatalog = (Catalog)Serializer.Deserialize(XmlReader);
            Console.WriteLine("Catalog Date=" + _BooksCatalog.Date.ToString("yyyy-MM-dd"));
            foreach (var Book in _BooksCatalog.Book)
            {
                Console.WriteLine("\tId=" + Book.Id);
                Console.WriteLine("\tIsbn=" + Book.ISBN);
                Console.WriteLine("\tAuthor=" + Book.Author);
                Console.WriteLine("\tTitle=" + Book.Title);
                Console.WriteLine("\tGenre=" + Book.Genre);
                Console.WriteLine("\tPublisher=" + Book.Publisher);
                Console.WriteLine("\tPublish Date=" + Book.PublishDate.ToString("yyyy-MM-dd"));
                Console.WriteLine("\tDescription=" + Book.Description);
                Console.WriteLine("\tRegister Date=" + Book.RegistrationDate.ToString("yyyy-MM-dd"));
                Console.WriteLine("\t----------------x---------------");
            }
            XmlReader.Close();
        }
        /// <summary>
        /// This method Serializes Object data to Json
        /// </summary>
        private static void JsonSerialize()
        {
            Console.WriteLine("-----------------JSON Data------------------");
            string json = JsonConvert.SerializeObject(_BooksCatalog, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}