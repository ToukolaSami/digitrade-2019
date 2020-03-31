using System;
using System.IO;

namespace Harjoitustyö
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            char userChoise;
            do
            {
                
                userChoise = UserInterface();
                switch (userChoise)
                {
                    case '1':
                        CheckNumber();
                        break;
                    
                    case '0':
                        break;

                    default:
                        Console.WriteLine("\nTarkista syöte!.");
                        Console.ReadLine();
                        break;
                }
            } while (userChoise != '0');
        }
        static char UserInterface()
        {
           
            
            Console.WriteLine("[1] Tarkista viitenumero.");
            Console.WriteLine("[0] Close program.");
            Console.Write("Valitse ");
            return char.ToUpper(Console.ReadKey().KeyChar);
        }

        static void CheckNumber()
        {
            string number = Input();
            int sum = 0;
            int[] multiplier = new int[] { 7, 3, 1 };
            int[] array = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                array[i] = int.Parse(number[i].ToString());
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                sum += array[array.Length - 2 - i] * multiplier[i % 3];
            }
            int checkNumber = 10 - (sum % 10);
            if (checkNumber == 10)
            {
                checkNumber = 0;
            }
            if (array[array.Length - 1] == checkNumber)
            {
                Console.WriteLine($"Viitenumero {number} on ok.");
            }
            else
            {
                Console.WriteLine($"Viitenumero {number} on väärin.");
            }
            Console.WriteLine("\nPaina jotain näppäintä palataksesi alkuun");
            Console.ReadLine();
            Console.Clear();
        }
        static string Input()
        {
            string input = String.Empty;
            int inputNum = 0;
            do
            {
                Console.Write("\n\nSyötä viitenumero, jossa on vain numeroita ja on 4-20 merkkiä pitkä:");
                input = Console.ReadLine();
                Console.Clear();
            } while (input.Length <= 4 || input.Length >= 20 || !Int32.TryParse(input, out inputNum) || inputNum < 0);
            return input;
        }
    }
}