using System;

namespace toisto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kertotaulu luvuille 1-9\n");

            for (int i = 1; i <= 9; i++)
            {
                for (int n = 1; n <= 9; n++)
                {
                    Console.WriteLine($"{i} x {n} = {i * n}");
                }
            }
        }
    }
}
