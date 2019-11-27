using System;

namespace Toistorakenne2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee lukua edeltävät luvut yhteen.");
            Console.Write("Syötä luku: ");
            int userInput = int.Parse(Console.ReadLine());
            int n = 1;
            int answer = 0;

            Console.WriteLine("-------------------------------------------");

            if (userInput > 0)
            {
                while (n <= userInput)
                {
                    answer = (answer + n);
                    n++;
                }
                Console.WriteLine("Lukujen summa on: " + answer);
            }
            else
            {
                Console.WriteLine("Luku on 0");
            }
            Console.ReadLine();
        }
    }
}
