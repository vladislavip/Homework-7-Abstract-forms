using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Paralelipiped : SpatialForm
    {
        //        Duzbucaqlı Paralelepiped
        //         V = a x b x c;
        //         S(tam) = 2 x(ab + bc + ac)

        public double Volume(double side,double side1,double side2)

        {
            double v = side * side1 * side2;

            return v;

        }

        public double Area(double side,double side1, double side2)

        {
            double v = 2*(side*side1+side1*side2+side*side2);

            return v;
        }
    }
}