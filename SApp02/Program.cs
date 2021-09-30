using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SApp02
{
    class Program
    {

        public static Person LoadPersonFromXml(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            using (Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                return (Person)xmlSerializer.Deserialize(stream);
            }

        }

        public static void SavePersonToXml(Person person, string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            using (Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(stream, person);
            }

        }


        static void Main(string[] args)
        {
            // XmlSerializer

            Person person = LoadPersonFromXml(AppDomain.CurrentDomain.BaseDirectory + "Person.xml");
            if (person != null)
            {
                Console.WriteLine($"{person.LastName} {person.FirstName} {person.SecondName} {person.Age}");
            }

            person.Age = 45;
            person.FirstName = "Александр";

            SavePersonToXml(person, AppDomain.CurrentDomain.BaseDirectory + "Person.new.xml");


            Console.ReadLine();


        }
    }
}
