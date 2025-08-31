using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Fahrenheit_to_Celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double Fehrenheit = 97;
            //Console.WriteLine("tempreature is Fehrenheit : " + Fehrenheit);

            //double celsius = (Fehrenheit - 32) * 5 / 9;
            //Console.WriteLine("Tempreature is celsius : " + celsius);
            //Console.ReadLine();

            //===========================================================================


            //using user input
            //Console.WriteLine("Enter Fehrenheit Temperature : ");
            //double Fehrenheit=Convert.ToDouble(Console.ReadLine());

            //double celsius = (Fehrenheit - 32) * 5 / 9;
            //Console.WriteLine("Tempreature is celsius : " + celsius);
            //Console.ReadLine();


            //===========================================================================

            //using user input with function

            Console.WriteLine("Enter Fehrenheit Temperature : ");
            double Fehrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = ToCelsius(Fehrenheit);
            Console.WriteLine("Tempreature is celsius : " + celsius);
            Console.ReadLine();

        }
        public static double ToCelsius(double Fehrenheit)
        {
            return (Fehrenheit - 32) * 5 / 9;
        }
    }
}
