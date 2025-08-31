using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octal_to_Binary_Number_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string octalNumber = "170";
            System.Console.WriteLine("Octal Number is: " + octalNumber);
            int i = 0;
            string binary = "";
            while (i < octalNumber.Length)
            {
                char c = octalNumber[i];
                switch (c)
                {
                    case '0':
                        binary += "000";
                        break;
                    case '1':
                        binary += "001";
                        break;
                    case '2':
                        binary += "010";
                        break;
                    case '3':
                        binary += "011";
                        break;
                    case '4':
                        binary += "100";
                        break;
                    case '5':
                        binary += "101";
                        break;
                    case '6':
                        binary += "110";
                        break;
                    case '7':
                        binary += "111";
                        break;
                    default:
                        System.Console.WriteLine("\nInvalid Octal Digit " + octalNumber[i]);
                        break;
                }
                i++;
            }
            System.Console.WriteLine("Bianry value is: " + binary);
            Console.ReadKey();
        }
    }
}
