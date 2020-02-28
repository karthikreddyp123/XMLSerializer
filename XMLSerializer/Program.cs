using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XMLSerializer
{
    class Program
    {
        static void Main(string[] args)
        {

            Catalog catalog1 = null;
            string path = @"C:\Users\Karthik_Patlolla\Desktop\books.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(Catalog));
            XmlReaderSettings settings = new XmlReaderSettings();
            XmlReader reader = XmlReader.Create(path, settings);
            catalog1 = (Catalog)serializer.Deserialize(reader);
            foreach(var book in catalog1.book)
            {
                Console.WriteLine("Book Id=" + book.id);
                Console.WriteLine("Book Isbn=" + book.isbn);
                Console.WriteLine("Book author=" + book.author);
                Console.WriteLine("Book title=" + book.title);
                Console.WriteLine("Book Genre=" + book.genre);
                Console.WriteLine("Book publisher=" + book.publisher);
                Console.WriteLine("Book Publish Date=" + book.publish_date);
                Console.WriteLine("Book description=" + book.description);
                Console.WriteLine("Book register date=" + book.registration_date);
            }

            reader.Close();
            XmlSerializer xs = new XmlSerializer(typeof(Catalog));
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "http://library.by/catalog");
            TextWriter txtWriter = new StreamWriter(@"C:\Temp\Serialization.xml");

            xs.Serialize(txtWriter, catalog1, ns);

            txtWriter.Close();

            //DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Catalog));
            //MemoryStream msObj = new MemoryStream();
            //js.WriteObject(msObj, catalog1);
            //msObj.Position = 0;
            //StreamReader sr = new StreamReader(msObj);
            //string json = sr.ReadToEnd();
            string json = JsonConvert.SerializeObject(catalog1, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}
