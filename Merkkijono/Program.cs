using System;

namespace Merkkijono
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä jotain: ");
            string a = Console.ReadLine();
            int i = a.Length;
            Console.WriteLine($"Syötteessä on {i} merkkiä.");

        }
    }
}
