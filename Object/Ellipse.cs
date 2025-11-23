using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Ellipse : Rectangle
    {
        public override double Area
        {
            get
            {
                return Math.PI * Width * Length;
            }
        }

        public Ellipse(string name, double width, double length) : base(name, width, length) { }
    }
}
