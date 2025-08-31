using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profit_loss_C_
{
    internal class Program
    {
        // Function to calculate Profit
        static double Profit(double costPrice, double sellingPrice)
        {
            double profit = (sellingPrice - costPrice);
            return profit;
        }
        // Function to calculate Loss
        static double Loss(double costPrice, double sellingPrice)
        {
            double Loss = (costPrice - sellingPrice);
            return Loss;
        }
        static void Main(string[] args)
        {
            double costPrice = 1600, sellingPrice = 2000;
            Console.WriteLine(" Cost Price :" + costPrice);
            Console.WriteLine(" Selling Price :" + sellingPrice);
            if (sellingPrice == costPrice)
                Console.Write("No profit nor Loss");
            else if (sellingPrice > costPrice)
            {
                Console.WriteLine(" Profit :" + Profit(costPrice, sellingPrice));
            }
            else
            {
                Console.WriteLine(" Loss :" + Loss(costPrice, sellingPrice));
            }
            Console.ReadKey();

        }
    }
}
