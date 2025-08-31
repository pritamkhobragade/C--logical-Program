using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octal_to_Decimal_Number_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int OctalNumber = 253;
            Console.WriteLine($"Octal Number : {OctalNumber}");
            int Decimal_Number = 0;
            int BASE = 1;
            int temp = OctalNumber;
            while (temp > 0)
            {
                int last_digit = temp % 10;
                temp /= 10;
                Decimal_Number += last_digit * BASE;
                BASE *= 8;
            }
            Console.WriteLine($"Decimal Number : {Decimal_Number}");
            Console.ReadKey();
        }
    }
}
