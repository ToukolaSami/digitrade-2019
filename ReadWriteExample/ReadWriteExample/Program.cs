using System;

namespace ReadWriteExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReadWriteExample");//Tulostaa näytölle viestin
            Console.Write("Moi, kirjoita nimesi: ");//Tulostaa näytölle
            //Luetaan käyttäjän syöttämät merkit
            //sijoitetaan merkkijono muuttujaan userInput
            string userInput = Console.ReadLine();
            Console.WriteLine("-------------------------");//Tulostaa näytölle viestin
            Console.WriteLine("Moi " + userInput + "!");//Tulostaa näytölle viestin ja muuttujanarvon
            Console.WriteLine("Moi {0}!", userInput);//Erityylit sama asia
            Console.WriteLine($"Moi {userInput}!");
            //Tulostuksen käyttö ja muuttujien käyttö
            //tulostuksen yhteydessä $-merkin avulla = string.Format()
        }
    }
}