using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_power
{
    internal class Program
    {
        public class PowerOf2
        {
            static void Main(string[] args)
            {
                //try
                //{
                //    int no;
                //    int remainder;

                //    Console.WriteLine("Enter the number: ");
                //    no = Convert.ToInt32(Console.ReadLine());

                //    if(no==1)
                //        Console.WriteLine("it is power of 2");
                //    else
                //    {
                //        while(no>1)
                //        {
                //            remainder = no % 2;
                //            if (remainder != 0)
                //                break;
                //            no /= 2;
                //        }
                //        if (no == 1)
                //            Console.WriteLine("it is power of 2");
                //        else
                //            Console.WriteLine("it is not power of 2");
                //    }
                //}
                //catch(Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
                //Console.ReadLine();


                //========================================================================



                //using function

                try
                {
                    int no;
                    Console.WriteLine("Enter a no to check");
                    no = Convert.ToInt32(Console.ReadLine());
                    PowerOf2 pr = new PowerOf2();
                    bool check = pr.IsPowerOf2(no);
                    if (check)
                        Console.WriteLine("It is a power of 2");
                    else
                        Console.WriteLine("It is not a power of 2");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();


            }
            public bool IsPowerOf2(int no)
            {
                if (no == 1)
                    return true;
                int remainder;
                while (no > 1)
                {
                    remainder = no % 2;
                    if (remainder != 0)
                        break;
                    no /= 2;
                }
                if (no == 1)
                    return true;
                else
                    return false;
            }
        }
    }
}
