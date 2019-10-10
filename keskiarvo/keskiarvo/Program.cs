using System;

namespace keskiarvo
{
    class Program
    {
        static void Main(string[] args)
        {
            double summa = 0;
            int i = 1;
            Console.WriteLine("Ohjelma laskee annettujen lukujen keskiarvon. ");
            Console.Write("Kuinka monta lukua syötät? ");
            int lkm = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------");

            while (i <= lkm)
            {
                int x = int.Parse(Console.ReadLine());
                summa = summa + x;
                i = i + 1;
            }

            if (lkm > 0)
            {
                double ka = summa / lkm;
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Keskiarvo on: " + ka);
            }
            else
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Lukuja ei ole syötetty");
            }
        }
    }
}