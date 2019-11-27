using System;

namespace Toistorakenne1
{
    class Program
    {
        //Define 
        static void Main(string[] args)
        {
            int n = 0;
            int fact = 1;
            //Tulostetaan viestikäyttäjälle
            Console.WriteLine("Kertoman laskenta");
            Console.Write("Minkä luvun kertoma lasketaan? ");

            //Luetaan käyttäjän syöte ja pakotetaan se integer muotoon
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------");

            //Ehto, jossa testataan käyttäjän syöttämäarvo
            //Ohjelma logiikka
            if (n < 0)
            {
                Console.WriteLine("Virheellinen syöte!");
            }
            else
            {
                //Silmukka, jossa lasketaan kertoman arvo
                while (n > 0)
                {
                    fact = fact * n;// lasketaan kertoma joka kierroksella
                    n = n - 1; //vähentää arvoa yhdellä
                }
                //Tulosta vastaus näytölle
                Console.WriteLine("Vastaus: " + fact);
            }
            Console.ReadLine();
        }
    }
}
