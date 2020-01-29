using System;

namespace Taulukko3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taulukko 3.1\n[X] = [arvo]");
            int[] numbers = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(20);
            }
            for (int n = 0; n < numbers.Length; n++)
            {
                Console.WriteLine($"[{n}] = {numbers[n]:D2}");
            }
            
        }
    }
}
