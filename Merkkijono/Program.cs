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
            Console.WriteLine("\nSyötteestä on vaihdettu  e-kirjaimet @-merkiksi.");
            Console.WriteLine(a.Replace("e", "@"));


        }
    }
}
