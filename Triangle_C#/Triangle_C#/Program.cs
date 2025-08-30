using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int side1 = 4;
            //int side2 = 13;
            //int side3 = 15;

            //double semiparameter = (side1 + side2 + side3) / 2;
            //double area=Math.Sqrt(semiparameter * (semiparameter - side1) * 
            //    (semiparameter - side2) * (semiparameter - side3 ));

            //Console.WriteLine($"area of triangle : {area}");

            //=======================================================================

            //Console.WriteLine("Enter the Side1");
            //double side1= int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the Side2");
            //double side2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the Side3");
            //double side3 = int.Parse(Console.ReadLine());

            //double semiparameter = (side1 + side2 + side3);
            //double area =Math.Sqrt(semiparameter * (semiparameter-side1) * 
            //    (semiparameter-side2) * (semiparameter-side3));

            //Console.WriteLine($"area of trangle : {area}");
            //Console.ReadLine();


            //=======================================================================

            Console.Write("Enter the Base : ");
            double Base =double.Parse(Console.ReadLine());

            Console.Write("Enter the height : ");
            double height = double.Parse(Console.ReadLine());

            double area = (Base * height )/ 2;
            Console.WriteLine($"Area of Triangle : {area}");
            Console.ReadKey();

        }
    }
}
