using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class SomeClass
    {
        public event LuckyNumberWasEnteredDelegate LuckyNumber;
        public int Num
        {
            get
            {
                return Num;
            }
            set
            {
                Num = value;

            }
        }
        protected void OnLockyNumber()
        {
            if (Num == 999)
                if (LuckyNumber != null)
                    LuckyNumber();
        }
    }
}
