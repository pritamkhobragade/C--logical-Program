using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //l= length , b=breadth, area= area of rectangle
            //int l = 15;
            //int b = 6;
            //int area = l * b;
            //Console.WriteLine(area);
            //Console.ReadLine();

            Console.Write("Enter the Length :");
            int l=int.Parse(Console.ReadLine());

            Console.Write("Enter the Breadth:");
            int b = int.Parse(Console.ReadLine());

            int area = l * b;
            Console.Write($"area of rectangle is : {area}");
            Console.ReadLine();
        }
    }
}
