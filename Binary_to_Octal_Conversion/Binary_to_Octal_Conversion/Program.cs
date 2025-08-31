using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_to_Octal_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long Temp, BinaryNumber, p = 1, i = 1, j, d;
            long DecimalNo = 0;
            long OctalNo = 0;

            Console.Write("Input a binary number :");
            BinaryNumber = Convert.ToInt32(Console.ReadLine());
            Temp = BinaryNumber;
            for (j = BinaryNumber; j > 0; j = j / 10)
            {
                d = j % 10;
                if (i == 1)
                    p = p * 1;
                else
                    p = p * 2;

                DecimalNo = DecimalNo + (d * p);
                i++;
            }
            i = 1;

            for (j = DecimalNo; j > 0; j = j / 8)
            {
                OctalNo = OctalNo + (j % 8) * i;
                i = i * 10;
                BinaryNumber = BinaryNumber / 8;
            }

            Console.Write("\nThe Binary Number : {0}\nThe equivalent Octal  Number is : {1} \n\n", Temp, OctalNo);
            Console.ReadKey();
        }
    }
}
