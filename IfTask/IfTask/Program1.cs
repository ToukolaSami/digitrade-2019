using System;

namespace IfTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee onko luku positiivinen vai negatiivinen!");
            Console.Write("Syötä luku: ");
            double userNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------------------");

            if (userNumber == 0)
                Console.WriteLine("Luku on nolla!");

            else if (userNumber > 0)
                Console.WriteLine($"Luku {userNumber} on positiivinen!");

            else if (userNumber < 0)
                Console.WriteLine($"Luku {userNumber} on negatiivinen!");
        }
    }
}
