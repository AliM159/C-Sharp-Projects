using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    class Circle : Square
    {
        public override double Area
        {
            get
            {
                return Math.PI * Length * Length;
            }
        }

        public Circle(string name, double lenght) : base(name, lenght) { }
    }
}
