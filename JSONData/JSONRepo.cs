using MockData;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONData
{
    public class JSONRepo : IObjectRepo
    {
        const string path = "People.json";
        public int Add(Person person)
        {
            string data = File.ReadAllText(path);

            JObject people = JObject.Parse(data);
            people.Add(JsonConvert.SerializeObject(person));       
            string serializedJson = JsonConvert.SerializeObject(people);
            //serializedJson = $"{serializedJson},{data}";
            //File.WriteAllText(path, serializedJson); //Bez formatowania.         
            File.WriteAllText(path, JToken.Parse(serializedJson).ToString()); // Z formatowaniem.
            return -1;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
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
