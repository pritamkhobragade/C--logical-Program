using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //surface area of cube

            //Console.Write("Enter the Side : ");
            //decimal side=Convert.ToDecimal(Console.ReadLine());

            //decimal area = 6 * (side * side);
            //Console.WriteLine("Surface area of cube : "+ area);

            //====================================================================

            //volume of cube
            Console.Write("Enter the Side : ");
            decimal side = Convert.ToDecimal(Console.ReadLine());

            decimal area = side * side * side;
            Console.WriteLine("Surface area of cube : " + area);
            Console.ReadLine();
        }
    }
}
