using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class SpatialForm
    {

        private double radius;
        private double height;
        private double side;


        public double Radius 
        { 
            get 
            {
                return radius;
            }
            set
            {
                if (value < 1) 
                {
                    throw new Exception("wrong input");
                }

                radius = value;
            }            
        
        }


        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 1)
                {
                    throw new Exception("wrong input");
                }

                height = value;
            }

        }

        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                if (value < 1)
                {
                    throw new Exception("wrong input");
                }

                side = value;
            }

        }








    }


}
