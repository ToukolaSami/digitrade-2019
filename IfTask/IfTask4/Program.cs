using System;

namespace IfTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma järjestelee numerot pienimmästä suurimpaan!");

            //Tietojen kysely
            Console.Write("Syötä 1. luku: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Syötä 2. luku: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Syötä 3. luku: ");
            int z = int.Parse(Console.ReadLine());


            //Logiikka jolla ratkaistaaan ongelma
            if (x < y && x < z)
            {
                Console.Write($"Järjestys on {x} < {y} < {z}");
            }

            if (y < x && y < z)
            {
                Console.Write($"Järjestys on {y} < {x} < {z}");
            }
            if (z < x && z < y)
            {
                Console.Write($"Järjestys on {z} < {x} < {y}");
            }

        }
    }
}
