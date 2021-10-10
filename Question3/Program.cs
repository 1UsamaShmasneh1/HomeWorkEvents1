using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    public class Program
    {
        public static event DiscountDelegate Discount;
        public static void Main(string[] args)
        {
            Discount = Events.GetDiscount;
            Student student = new Student();
            StudentList.students.Add(student);
            if(StudentList.students.Count > 0 && StudentList.students.Count % 5 == 0)
            {
                student.Discount = 5;
                Discount();
            }
        }
    }
}