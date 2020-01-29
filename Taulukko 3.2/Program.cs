using System;

namespace Taulukko_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taulukko 3.2\n[XX,XX] = [arvo]");
            Random rnd = new Random();
            int width = 10; int height = 20;
            int[,] array = new int[width, height];


            for (int i = 0; i < width; i++)
            {
                for (int n = 0; n < height; n++)
                {
                    array[i, n] = rnd.Next(100);
                }
            }
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.WriteLine($"[{i:d2},{j:d2}] = {array[i, j]:d2}");
                }
            }
        }
    }
}
