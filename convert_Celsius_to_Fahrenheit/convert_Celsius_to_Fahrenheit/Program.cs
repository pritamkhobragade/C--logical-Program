using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert_Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Celsius to Fahrenheit conversion
            // float Celsius =35;
            // Console.Write("Temperature in Celsius Is : " + Celsius);

            // float Fahrenheit = (Celsius * 9 / 5) + 32;
            //Console.Write("\n Temperature in Fahrenheit Is : " + Fahrenheit);
            // Console.ReadLine();

            //==================================================================

            //Fahrenheit to Celsius using user input

            //Console.WriteLine("Enter Temperature in Fahrenheit : ");
            //double Celsius = Convert.ToDouble(Console.ReadLine());

            //double Fahrenheit = (Celsius * 9) / 5 + 32;
            //Console.WriteLine("Temperature in Fahrenheit is : " + Fahrenheit);
            //Console.ReadLine();

            //==================================================================


            //Celsius to Fahrenheit using function

            Console.Write("Enter temperature in Celsius : ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = CelsiusFahrenheit(celsius);
            Console.WriteLine("The converted fahrenheit temperature is : " + fahrenheit);
            Console.ReadLine();

        }
        private static double CelsiusFahrenheit(double celsius)
        {
            return ((celsius * 9) / 5) + 32;
        }
    }
}
