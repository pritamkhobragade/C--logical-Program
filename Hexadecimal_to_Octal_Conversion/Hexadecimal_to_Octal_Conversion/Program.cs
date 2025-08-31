using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexadecimal_to_Octal_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long deci = 0;
            string hexadecimal = "AC3";
            Console.WriteLine("hexadecimal number is : " + hexadecimal);
            long c = hexadecimal.Length - 1;
            for (int i = 0; i < hexadecimal.Length; i++)
            {
                char ch = hexadecimal[i];
                switch (ch)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        deci = deci + Int32.Parse(ch.ToString()) * (int)Math.Pow(16, c);
                        c--;
                        break;
                    case 'a':
                    case 'A':
                        deci = deci + 10 * (int)Math.Pow(16, c);
                        c--;
                        break;
                    case 'b':
                    case 'B':
                        deci = deci + 11 * (int)Math.Pow(16, c);
                        c--;
                        break;
                    case 'c':
                    case 'C':
                        deci = deci + 12 * (int)Math.Pow(16, c);
                        c--;
                        break;
                    case 'd':
                    case 'D':
                        deci = deci + 13 * (int)Math.Pow(16, c);
                        c--;
                        break;
                    case 'e':
                    case 'E':
                        deci = deci + 14 * (int)Math.Pow(16, c);
                        c--;
                        break;
                    case 'f':
                    case 'F':
                        deci = deci + 15 * (int)Math.Pow(16, c);
                        c--;
                        break;
                    default:
                        Console.Write("Invalid hexa input");
                        break;
                }
            }
            string octal = "";
            while (deci > 0)
            {
                octal = deci % 8 + octal;
                deci = deci / 8;
            }
            Console.Write("Equivalent Octal Value of hexadecimal number is= " + octal);
            Console.ReadKey();
        }
    }
}
