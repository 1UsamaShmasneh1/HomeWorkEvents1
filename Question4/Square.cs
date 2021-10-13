using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    public class Square: Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Square()
        {
            X = 10;
            Y = 5;
        }

        public override event Outch OutchEvent;

        public override void OnOutch()
        {
            if (OutchEvent != null)
                OutchEvent();
        }
    }
}
