using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class Program
    {
        public static event LuckyNumberWasEnteredDelegate luckyNumber;
        public static void Main(string[] args)
        {
            luckyNumber = Print;
            SomeClass someClass = new SomeClass();
            int num;
            for(int i = 0; i < 10; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                someClass.Num = Convert.ToInt32(Console.ReadLine());
                if (num == 999 || someClass.Num == 999)
                {
                    luckyNumber();
                    break;
                }                    
            }
        }
        public static void Print()
        {
            Console.WriteLine("Lucky number was entered");
        }
    }
}