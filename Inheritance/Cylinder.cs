using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Cylinder : SpatialForm
    {
        //           Silindr
        //         V = pi x r^2 x l
        //         S(ot) = pi x r^2;
        //         S(tam) = 2 x S(ot) +2 x pi x r x l

        public double Volume(double radius, double height)

            {

            double v = Math.PI * Math.Pow(radius, 2) * height;

            return v;

            }


        public double CircleEdgeArea(double radius)

        {

            double a = Math.PI * Math.Pow(radius, 2);

            return a;

        }


        public double  TotalArea (double circarea, double radius, double height)

        {

            double aa= 2 * circarea + 2 * Math.PI * radius * height;

            return aa;

        }


    }
}
