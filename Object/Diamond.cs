using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Diamond : Rectangle
    {
        public override double Area
        {
            get
            {
                return Width * Length;
            }
        }


        public Diamond(string name, double width, double length) : base(name, width, length) { }
    }
}
