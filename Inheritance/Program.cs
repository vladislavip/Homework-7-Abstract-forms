using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sinif kimi FəzaFiquru qəbul edilir.Və miraslılıq tətbiq etməklə aşağıda qeyd 
            //    edilən fəza fiqurlarının Sahe ve səth 
            //    sahəsinin metodlarin realizasiyasini etmək

            //        Konus
            //        S(ot) = pi x r^2 
            //        V = S(ot) x H / 3


            //           Silindr
            //         V = pi x r^2 x l
            //         S(ot) = pi x r^2;
            //         S(tam) = 2 x S(ot) +2 x pi x r x l


            //        Duzbucaqlı Paralelepiped
            //         V = a x b x c;
            //         S(tam) = 2 x(ab + bc + ac)


            Cone cone = new Cone();
            Cylinder cylinder = new Cylinder(); 
            Paralelipiped paralipiped=new Paralelipiped();


            Console.WriteLine("Type Cone Radius");
            cone.Radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type Cone Height");
            cone.Height = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Type Cylinder Radius");
            cylinder.Radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type Cylinder Height");
            cylinder.Height = Convert.ToDouble(Console.ReadLine());


           Console.WriteLine("Type Paralepiped side 1");
            paralipiped.Side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type Paralepiped side 1");
            paralipiped.Side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type Paralepiped side 1");
            paralipiped.Side2 = Convert.ToDouble(Console.ReadLine());

            double  conecircarea = cone.CircleEdgeArea(cone.Radius);

            Console.WriteLine($"Cone circle areea is {conecircarea}");

            double  conevolume= cone.Volume(conecircarea,cone.Height);

            Console.WriteLine($"Cone volume is {conevolume}");



            double cylindervolume=cylinder.Volume(cylinder.Radius,cylinder.Height);

            Console.WriteLine($"Cylinder volume is {cylindervolume}");

            double cylinderedgearea = cylinder.CircleEdgeArea(cylinder.Radius);
            Console.WriteLine($"Cylinder circles area is {cylinderedgearea}");

            double cylindertotalarea = cylinder.TotalArea(cylinderedgearea, cylinder.Radius, cylinder.Height);

            Console.WriteLine($"Cylinder total area  is {cylindertotalarea}");




            double paralelipipedvolume = paralipiped.Volume(paralipiped.Side, paralipiped.Side1, paralipiped.Side2);
            Console.WriteLine($"Paralelipiped volume is {paralelipipedvolume}");


            double papalelipipedarea = paralipiped.Area(paralipiped.Side, paralipiped.Side1, paralipiped.Side2);

            Console.WriteLine($"Paralelipiped total area  is {papalelipipedarea}");




        }
    }
}
