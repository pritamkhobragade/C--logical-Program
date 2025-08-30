using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginAuthetication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your UserName");
            string Username = Console.ReadLine();
            Console.WriteLine("Enter your Password");
            string Password = Console.ReadLine();


            if (Username == "Pritam" && Password == "Pritam@123")
            {
                Console.WriteLine("Login Successfully !");
            }
            else
            {
                Console.WriteLine("Incorrect Username or Password ");
            }

            Console.ReadLine();
        }
    }
}
