using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Radius : ");
            double r=Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * r * r;
            Console.WriteLine($"Area of circle : {area}");
            Console.ReadLine();
        }
    }
}
