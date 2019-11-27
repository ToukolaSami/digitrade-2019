using System;

namespace Toistorakenne3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee parillisten ja parittomien lukujen summan syötetystä luvusta");
            Console.Write("Syötä luku: ");
            int userInput = int.Parse(Console.ReadLine());

            int n = 1;
            int odd = 0;
            int even = 0;

            Console.WriteLine("----------------------------------------------------");

            if (userInput >= 1)
            {
                while (n <= userInput)
                {
                    if (n % 2 == 0)
                    {
                        even = even + n;
                    }
                    else
                    {
                        odd = odd + n;
                    }
                    n++;
                }
                Console.WriteLine("Parittomien summa on " + odd + " ja parillisten summa " + even);
            }
            else
            {
                Console.WriteLine($"Luku {userInput} on liian pieni.");
            }
            Console.ReadLine();
        }
    }
}
