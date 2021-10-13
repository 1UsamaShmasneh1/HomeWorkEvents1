using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    public class Dote: Shape
    {
        public int X {  get; set; }
        public int Y {  get; set; }
        public override event Outch OutchEvent;
        public Dote()
        {
            X = 0;
            Y = 0;
        }
        public override void OnOutch()
        {
            if (OutchEvent != null)
                OutchEvent();
        }

    }
}
