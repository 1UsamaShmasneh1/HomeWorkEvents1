using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class PersonList
    {
        static List<Person> personList = new List<Person>();

        public static void Add(Person person)
        {
            personList.Add(person);
        }
    }
}
