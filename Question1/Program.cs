using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Program
    {
        public static event TooLongNameEventDelegat tooLongName;
        public static void Main(string[] args)
        {
            tooLongName = Print;
            Person person = new Person();
            string? name = Console.ReadLine();
            if (name.Length > 10)
            {
                if (tooLongName is not null)
                    tooLongName();
            }
            else
            {
                person.Name = name;
            }
        }
        public static void Print()
        {
            Console.WriteLine("The name length is too long");
        }
    }
}