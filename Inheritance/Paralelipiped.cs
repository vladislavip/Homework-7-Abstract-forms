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

        public double Volume(double side)

        {
            double v = Math.Pow(side, 3);

            return v;

        }

        public double Area(double side)

        {
            double v = Math.Pow(side, 3);

            return v;
        }
    }
}