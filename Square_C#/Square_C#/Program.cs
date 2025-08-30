using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int side = 10;
            //int area =side* side;
            //Console.WriteLine($"Area of Square : {area}");

            Console.WriteLine("Enter the Number");
            //int side=Convert.ToInt32(Console.ReadLine());
            int side=int.Parse(Console.ReadLine());

            int area= side*side;
            Console.WriteLine($"Area of Square is : {area}");
            Console.ReadLine();
        }
    }
}
