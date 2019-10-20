using System;

namespace HintaLaskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            double alennus = 0;
            string varusmies;
            string opiskelija;
            string mtkjäsen;
            int hinta = 16;
            int ikä = 0;

            Console.WriteLine("Laskuri laskee maatalousnäyttelynlipun hinnan");
            Console.WriteLine("----------------------------------------------");

            Console.Write("Oletko varusmies?    Kyllä / En ");
            varusmies = Console.ReadLine().ToUpper();
            if (varusmies[0] == 'K')
            {
                alennus = 0.5;
            }
            else
            {
                Console.Write("Oletko opiskelija?   Kyllä / En ");
                opiskelija = Console.ReadLine().ToUpper();
                Console.Write("Oletko mtk:n jäsen?  Kyllä / En ");
                mtkjäsen = Console.ReadLine().ToUpper();

                if (opiskelija[0] == 'K' && mtkjäsen[0] == 'K')
                {
                    alennus = 0.6;
                }

                else if (opiskelija[0] == 'K' && mtkjäsen[0] == 'E')
                {
                    alennus = 0.45;
                }

                if (opiskelija[0] == 'E')
                {
                    Console.Write("Kuinka vanha olet? ");
                    ikä = int.Parse(Console.ReadLine());

                    if (ikä < 7)
                    {
                        alennus = 1;
                    }

                    else if (ikä > 65 || ikä < 15)
                    {
                        alennus = 0.5;
                    }

                    else if (mtkjäsen[0] == 'K')
                    {
                        alennus = 0.15;
                    }

                    else
                    {
                        alennus = 0;
                    }
                }
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Lipunhinta on {hinta - (alennus * hinta)} euroa!");
        }
    }
}