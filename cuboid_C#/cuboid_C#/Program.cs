using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace cuboid_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //surface area of cuboid
            //float length = 5, width = 3, height = 4;

            //float surfaceArea = 2 * (length * width + width * height + height * length);
            //Console.WriteLine("Surface Area of Cuboid: " + surfaceArea);
            //Console.ReadLine();

            //====================================================

            //Console.WriteLine("Enter the Length : ");
            //double l = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the Width : ");
            //double w = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the Height : ");
            //double h = Convert.ToDouble(Console.ReadLine());

            //double surface_area = 2 * (l * w + w * h + h * l);
            //Console.WriteLine("Surface Area of Cuboid : " + surface_area);
            //Console.ReadLine();

            //====================================================

            //surface area of cuboid using function

            //Console.WriteLine("Enter the Length : ");  
            //double length = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the Width : ");
            //double width = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the Height : ");
            //double height = Convert.ToDouble(Console.ReadLine());

            //double surface_area = SurfaceArea(length, width, height);

            //Console.WriteLine("Surface Area of Cuboid : " + surface_area);
            //Console.ReadLine();

            //===========================================================

            //volume of cuboid 

            //float length = 5, width = 3, height = 4;

            //float volume = length * width * height;
            //Console.WriteLine("Surface Area of Cuboid: " + volume);
            //Console.ReadLine();

            //===========================================================

            //volume of cuboid  using user input

            //Console.WriteLine("Enter the Length : ");
            //double length = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the Width : ");
            //double width = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the Height : ");
            //double height = Convert.ToDouble(Console.ReadLine());

            //double volume = length * width * height;
            //Console.WriteLine("Volume of Cuboid : " + volume);
            //Console.ReadLine();

            //===========================================================

            //volume of cuboid using function

            Console.WriteLine("Enter the Length : ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Width : ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Height : ");
            double height = Convert.ToDouble(Console.ReadLine());

            double volume = Volume(length, width, height);
            Console.WriteLine("Volume of Cuboid : " + volume);
            Console.ReadLine();
        }
        //====================================================================================

        //surface area of cuboid  using function

        //public static double SurfaceArea(double length, double width, double height)
        //{
        //    return 2 * (length * width + width * height + height * length);
        //}

        //====================================================================================

        //volume of cuboid using function
        public static double Volume(double length, double width, double height)
        {
            return length * width * height;
        }



    }
}
