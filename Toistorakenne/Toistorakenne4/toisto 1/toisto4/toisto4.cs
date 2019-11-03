using System;

namespace toisto4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma simuloi kolikon heittoa.");
            Console.Write("Montako kertaa kolikkoa heitetään? ");
            int @throw = int.Parse(Console.ReadLine());
            int i = 0;
            int klaava = 0;
            int kruuna = 0;
            
            for (i = 0; i < @throw; i++)
            {
                Random rnd = new Random();
                int result = rnd.Next(2);
                if (result == 0)
                {
                    klaava++;
                }
                else if (result == 1)
                {
                    kruuna++;
                }
            }
            Console.WriteLine($"\nKolikkoa heitettiin {@throw} kertaa.\nKruunia heitettiin {kruuna} ja klaavoja {klaava}.");
        }
    }
}
