using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    public abstract class Shape
    {
        public abstract event Outch OutchEvent;
        public abstract void OnOutch();
    }
}
