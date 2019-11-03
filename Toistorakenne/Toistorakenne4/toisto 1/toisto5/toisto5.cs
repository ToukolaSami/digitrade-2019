using System;

namespace toisto5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa vakioveikkauksen rivin.\n1 = kotivoitto, X = tasapeli ja 2 = vierasvoitto\n");

            for (int n = 1; n <= 13; n++)
            {
                Random rnd = new Random();
                double result = rnd.NextDouble();

                if (result <= 0.4)
                {
                    Console.WriteLine("{0}.\t 1", n);
                }

                else if (result > 0.4 && result <= 0.6)
                {
                    Console.WriteLine("{0}.\t X", n);
                }

                else
                {
                    Console.WriteLine("{0}.\t 2", n);
                }
            }
        }
    }
}
