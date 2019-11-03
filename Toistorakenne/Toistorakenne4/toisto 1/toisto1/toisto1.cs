using System;

namespace toisto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee neliöjuuren luvuille 1-10.\n\nLuku\tNeliöjuuri");
            for (int i = 0; i < 10; i++)
            {
                double round = Math.Sqrt(i + 1);

                Console.WriteLine($"{i + 1}\t{Math.Round(round, 3)}");
            }
        }
    }
}
