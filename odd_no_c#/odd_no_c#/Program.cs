using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_no_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //Console.Write("Enter value a Number:");
            //int Number = Convert.ToInt32(Console.ReadLine());
            ////start with 1
            ////1+2 = 3
            ////3+2 = 5
            //for (int i = 1; i <= Number; i += 2)
            //{
            //    sum += i;
            //}
            //Console.Write($"Sum of Odd numbers from 1 to {Number} is : {sum}");
            //Console.ReadLine();


            //=========================================================================


            //int sum = 0;
            //Console.Write("Enter From Number:");
            //int FromNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter To Number:");
            //int ToNumber = Convert.ToInt32(Console.ReadLine());
            //if (FromNumber < ToNumber)
            //{
            //    for (int i = FromNumber; i <= ToNumber; i++)
            //    {
            //        if (i % 2 == 1)
            //            sum += i;
            //    }
            //    Console.Write($"Sum of Odd numbers from {FromNumber} to {ToNumber} is : {sum}");
            //}
            //else
            //{
            //    Console.Write("Invalid From and To Numbers");
            //}
            //Console.ReadLine();

            //=========================================================================

            int sum = 0;
            Console.Write("Enter From Number:");
            int FromNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter To Number:");
            int ToNumber = Convert.ToInt32(Console.ReadLine());
            if (FromNumber < ToNumber)
            {
                sum = FindSumOfOddNumbers(sum, FromNumber, ToNumber);
                Console.Write($"Sum of Odd numbers from {FromNumber} to {ToNumber} is : {sum}");
            }
            else
            {
                Console.Write("Invalid From and To Numbers");
            }
            Console.ReadLine();
        }

        private static int FindSumOfOddNumbers(int sum, int FromNumber, int ToNumber)
        {
            for (int i = FromNumber; i <= ToNumber; i++)
            {
                if (i % 2 == 1)
                    sum += i;
            }
            return sum;
        }
    }
}

