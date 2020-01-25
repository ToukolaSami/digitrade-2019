using System;

namespace Taulukko1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] productPrice = { 7.92, 72.0, 99.90 };
            int[] productAmount = { 1, 3, 2 };
            double[] productTotalPrice = { (productPrice[0] * productAmount[0]), (productPrice[1] * productAmount[1]), (productPrice[2] * productAmount[2]) };

            Console.WriteLine($"Product 1: {productTotalPrice[0]}");
            Console.WriteLine($"Product 2: {productTotalPrice[1]}");
            Console.WriteLine($"Product 3: {productTotalPrice[2]}");
        }
    }
}

