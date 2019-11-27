using System;

namespace Toistorakenne4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee lukua edeltävät luvut yhteen.");
            Console.Write("Syötä luku: ");
            int userInput = int.Parse(Console.ReadLine());
            int i = 0;
            int answer = 0;

            Console.WriteLine("----------------------------------------------");

            if (userInput > 0)
            {
                while (i <= userInput)
                {
                    answer = (answer + i);
                    i++;
                }
                Console.WriteLine("Lukujen summa on: " + answer);
            }
            else if (userInput < 0)
            {
                while (i >= userInput)
                {
                    answer = (answer + i);
                    i--;
                }
                Console.WriteLine("Lukujen erotus on: " + answer);
            }
            else
            {
                Console.WriteLine("Luku on 0");
            }
            Console.ReadLine();
        }
    }
}
