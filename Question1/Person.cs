using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    public class Person
    {
        public string? Name 
        {
            get
            {
                return Name;
            } 
            set
            {
                Name = value;
                OnLongNameEntered();
                //Lambda method
                
            }
        }

        public event TooLongNameEventDelegat TooLongName;


        protected void OnLongNameEntered()
        {
            if (Name.Length > 10)
                if (TooLongName is not null)
                    TooLongName();
        }
        public override string ToString()
        {
            return string.Format(Name);
        }
    }
}
