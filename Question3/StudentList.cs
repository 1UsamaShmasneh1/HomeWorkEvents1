using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    public class StudentList
    {
        public static List<Student> students = new List<Student>();
        public static void Add(Student student)
        {
            students.Add(student);
            if (students.Count > 0 && students.Count % 5 == 0)
            {
                Events.Discount();
            }
        }
    }
}
