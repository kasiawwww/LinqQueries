using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockData
{
    public class People
    {
        public static List<Person> PeopleList = new List<Person>
        {
            new Person
            {
                Id = 1,
                Name = "Janek",
                LastName = "Kowal",
                BirthDate = new DateTime (1990, 1,1),
                Height = 180,
                Weight = 90,          
            },
            new Person
            {
                Id = 2,
                Name = "Michał",
                LastName = "Maj",
                BirthDate = new DateTime (1995, 6,30),
                Height = 190,
                Weight = 95,
            },
            new Person
            {
                Id = 3,
                Name = "Maja",
                LastName = "Gaj",
                BirthDate = new DateTime (1985, 9,18),
                Height = 171,
                Weight = 63,
            },
            new Person
            {
                Id = 4,
                Name = "Anna",
                LastName = "Nowak",
                BirthDate = new DateTime (2000, 12,21),
                Height = 164,
                Weight = 57,
            }
        };
   
    }
}
