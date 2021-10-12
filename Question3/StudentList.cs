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
        public static event DiscountDelegate Discount;
        protected static int count = 0;
        public static void Add(Student student)
        {
            students.Add(student);
            count++;
            OnDiscountEvent(student);
        }
        protected static void OnDiscountEvent(Student student)
        {
            if(Discount != null)
                if (count == 5)
                {
                    student.Discount = 5;
                    count = 0;
                    Discount(student);
                }
        }
        //Console.WriteLine("You get 5% discount");
    }
}
