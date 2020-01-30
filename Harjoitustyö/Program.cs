using System;
using System.IO;

namespace Harjoitustyö
{
    class Program
    {
        static void Main(string[] args)
        {
            static char UserInterface()
            {
            Console.WriteLine("[T] Tarkastaa viitenumeron oikeellisuuden");
            Console.WriteLine("[L] Luodaan yksi viitenumero");
            Console.WriteLine("[R] Luodaan haluttu määrä viitenumeroita");
            Console.WriteLine("[N] Näytä luodut viitenumerot");
            Console.WriteLine("[X] Lopeta ohjelmansuoritus");
            Console.Write("Valitse ohjelma: ");

            return char.ToUpper(Console.ReadKey().KeyChar);
            }
        }
    }
}
