using System;

namespace IfTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää käyttäjän syöttämästä luvusta," +
                " onko se positiivinen vai negatiivinen!");
            Console.Write("Syötä kokonaisluku: ");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 0)
            {
                Console.WriteLine($"Luku {userNumber} on nolla!");
            }

            else if (userNumber > 0 && userNumber % 2 == 0)
            {
                Console.WriteLine($"Luku {userNumber} on positiivinen ja parillinen!");
            }

            else if (userNumber < 0 && userNumber % 2 == 0)
            {
                Console.WriteLine($"Luku {userNumber} on negatiivinen ja parillinen!");
            }

            else if (userNumber > 0 && userNumber % 2 == 1)
            {
                Console.WriteLine($"Luku {userNumber} on positiivinen ja pariton!");
            }

            else if (userNumber < 0 && userNumber % 2 == -1)
            {
                Console.WriteLine($"Luku {userNumber} on negatiivinen ja pariton!");
            }
        }
    }
}
