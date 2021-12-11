using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Cone : SpatialForm
    {

        //Konus
        //        S(ot) = pi x r^2 
        //        V = S(ot) x H / 3



        public double CircleEdgeArea(double radius)

        {

            Double s=Math.PI*Math.Pow(radius,2);    

            return s;
        }
        public double Volume(double CircleEdgeArea, double height )

        {

            Double v = CircleEdgeArea * height/3;

            return v;
        }

    }
}
