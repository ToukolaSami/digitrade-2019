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

            Console.WriteLine("------------------------------------");
            
            //Logiikka jolla ratkaistaaan ongelma
            if (x < y && y < z && x < z)
            {
                Console.WriteLine($"Järjestys on {x} < {y} < {z}");
            }
            else if (x > y && y < z && x < z)
            {
                Console.WriteLine($"Järjestys on {y} < {x} < {z}");
            }
            else if (x < y && y > z && x > z)
            {
                Console.WriteLine($"Järjestys on {z} < {x} < {y}");
            }
            else if (x < y && y > z && x < z)
            {
                Console.WriteLine($"Järjestys on {x} < {z} < {y}");
            }
            else if (x > y && y > z && x > z)
            {
                Console.WriteLine($"Järjestys on {z} < {y} < {x}");
            }
            else if (x > y && y < z && x > z)
            {
                Console.WriteLine($"Järjestys on {y} < {z} < {x}");
            }
            else
            {
                Console.WriteLine($"Järjestys on {x} < {y} < {z}");
            }
        }
    }
}