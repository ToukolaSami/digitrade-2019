using System;

namespace Toistorakenne5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee parillisten ja parittomien lukujen summan syötetystä luvusta");
            Console.Write("Syötä luku: ");
            int userInput = int.Parse(Console.ReadLine());

            int i = 0;
            int odd = 0;
            int even = 0;

            Console.WriteLine("--------------------------------------------------");

            if (userInput > 0)
            {
                while (i <= userInput)
                {
                    if (i % 2 == 0)
                    {
                        even = even + i;
                    }
                    else
                    {
                        odd = odd + i;
                    }
                    i++;
                }
                Console.WriteLine("Parittomien summa on " + odd + " ja parillisten summa " + even);
            }
            else if (userInput < 0)
            {
                while (i >= userInput)
                {
                    if (i % 2 == 0)
                    {
                        even = even + i;
                    }
                    else
                    {
                        odd = odd + i;
                    }
                    i--;
                }
                Console.WriteLine("Parittomien summa on " + odd + " ja parillisten summa " + even);
            }
            else
            {
                Console.WriteLine("Luku on nolla");
            }
            Console.ReadLine();
        }
    }
}
