using MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLData
{
    public class XMLRepo : IObjectRepo
    {
        const string path = "People.xml";
        public int Add(Person person)
        {
            int? id = GetList()
                .Select(p => p.Id)
                .OrderByDescending(p => p)
                .FirstOrDefault();
            var xd = XDocument.Load(path);
            XElement element = new XElement(nameof(person),

                new XAttribute(nameof(person.Id), id == null ? "1" : (id + 1).ToString()),
                new XAttribute(nameof(person.Name), person.Name),
                new XAttribute(nameof(person.LastName), person.LastName),
                new XAttribute(nameof(person.BirthDate), person.BirthDate.ToShortDateString()),
                new XAttribute(nameof(person.Height), person.Height.ToString()),
                new XAttribute(nameof(person.Weight), person.Weight.ToString())
                );

            xd.Element(nameof(People)).Add(element);
            xd.Save(path);
            return Convert.ToInt32(element.Attribute(nameof(person.Id)).Value); // Sprawdzenie czy jest nullem; TODO pobrać ostatni id.
        }

        public List<Person> GetList()
        {
            List<Person> result = new List<Person>();
            var xd = XDocument.Load(path);
            var tempList = xd.Element("People").Elements("Person").ToList();
            tempList.ForEach(u => {
                Person person = new Person
                {
                    Id = int.Parse(u.Attribute("Id").Value),
                    Name = u.Attribute("Name").Value.ToString(),
                    LastName = u.Attribute("LastName").Value.ToString(),
                    BirthDate = Convert.ToDateTime(u.Attribute("BirthDate").Value),
                    Weight = int.Parse(u.Attribute("Weight").Value),
                    Height = int.Parse(u.Attribute("Height").Value)
                };
                result.Add(person);
            });
            return result;
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Person GetFirstPerson()
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
