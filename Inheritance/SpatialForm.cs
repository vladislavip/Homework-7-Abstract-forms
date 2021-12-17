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
        private double side1;  // 2nd side of parallepiped
        private double side2;   // 3rd side of parallepiped



        public double Side2
        {
            get
            {
                return side2;
            }
            set
            {
                if (value < 1)
                {
                    throw new Exception("wrong input");
                }

                side2 = value;
            }

        }

        public double Side1
        {
            get
            {
                return side1;
            }
            set
            {
                if (value < 1)
                {
                    throw new Exception("wrong input");
                }

              side1 = value;
            }

        }

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
