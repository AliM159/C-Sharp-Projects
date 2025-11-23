using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complexity
{
    internal class Complex
    {


        public int Real { get; }
        public int Imaginary { get; }
        public double Modulus
        {
            get
            {
                return Math.Sqrt((Real * Real) + (Imaginary * Imaginary));
            }
        }

        public double Argument
        {
            get
            {
                return Math.Atan2(Imaginary , Real);
            }
        }

        public static Complex Zero
        {
            get
            {
                return new Complex(0, 0);
            }
        }


        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }



        public override string ToString()
        {
            return $"({Real}, {Imaginary})";
        }


        public static Complex operator +(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;
            return new Complex(real, imaginary);
        }


        public static Complex operator -(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;
            return new Complex(real, imaginary);
        }


        public static bool operator == (Complex lhs, Complex rhs)
        {
            if (lhs.Real.Equals(rhs.Real) && lhs.Imaginary.Equals(rhs.Imaginary))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator != (Complex lhs, Complex rhs)
        {
            if (lhs.Real.Equals(rhs.Real) && lhs.Imaginary.Equals(rhs.Imaginary))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
