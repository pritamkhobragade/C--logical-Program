using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_no_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sum =0;
            //Console.WriteLine("Enter value a number :");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for(int i = 1; i <= num; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine("Sum of first " + num + " natural numbers is: " + sum);
            //Console.ReadLine();

            //============================================================

            int sum = 0;
            Console.WriteLine("Enter from number :");
            int FromNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter to number :");
            int ToNumber = Convert.ToInt32(Console.ReadLine());

            if(FromNumber < ToNumber)
            {
                for (int i = FromNumber; i <= ToNumber; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine("Sum of first " + FromNumber + " to " + ToNumber + " natural numbers is: " + sum);
            }
            else
            {
                Console.WriteLine("From number should be less than To number");
            }
            Console.ReadLine();

        }
    }
}
