using System;

namespace IfTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku pariton vai parillinen!");
            Console.Write("Syötä kokonaisluku: ");
            int userNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------------------");

            if (userNumber % 2 == 0)
            {
                Console.WriteLine($"Luku {userNumber} on parillinen!");
            }
            else
            {
                Console.WriteLine($"Luku {userNumber} on pariton!");
            }

        }
    }
}
