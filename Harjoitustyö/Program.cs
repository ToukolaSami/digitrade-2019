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
                Console.Clear();
                userChoise = UserInterface();
                switch (userChoise)
                {
                    case '1':
                        try
                        {
                            if (CheckNumber(input) == true)
                            {
                                Console.WriteLine($"Viitenumero {input} on oikea");
                                Console.WriteLine("\nPaina jotain näppäintä palataksesi alkuun");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine($"Viitenumero {input} on väärä");
                                Console.WriteLine("\nPaina jotain näppäintä palataksesi alkuun");
                                Console.ReadLine();
                            }
                        }
                        catch
                        {
                            Console.WriteLine($"Väärä syöte!");
                            Console.WriteLine("\nPaina jotain näppäintä palataksesi alkuun");
                            Console.ReadKey();
                        } 
                        break;

                    case '2':
                        CreateNumber();
                        break;
                    case '3':
                        CreateMultiNumber();
                        break;

                    case '0':
                        break;

                    default:
                        Console.WriteLine("\nTarkista syöte!");
                        Console.ReadLine();
                        break;
                }
            } while (userChoise != '0');
        }

        static char UserInterface()
        {
            Console.WriteLine("[1] Tarkista viitenumero");
            Console.WriteLine("[2] Luo viitenumero");
            Console.WriteLine("[3] Luo monta viitenumeroa");
            Console.WriteLine("[0] Sulje ohjelma");
            Console.Write("Valitse: ");
            return char.ToUpper(Console.ReadKey().KeyChar);
        }

        static bool CheckNumber(string inputValue)
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
                return true;
            }
            else
            {
                return false;
            }
        }

        static string Input()

        {
            string input = String.Empty;
            int inputNum = 0;
            do
            {
                Console.Clear();
                Console.Write("Syötä viitenumero (4-20 numeroa): ");
                input = Console.ReadLine();
            } while (input.Length <= 4 || input.Length >= 20 || !Int32.TryParse(input, out inputNum) || inputNum < 0);
            return input;
        }

        static void CreateNumber()
        {
            string inputNumber;
            do
            {
                Console.Clear();
                Console.Write("Mikä on viitenumeron alkuosa (3-19 numeroa): ");
                inputNumber = Console.ReadLine();
            } while (inputNumber.Length <= 3 || inputNumber.Length >= 19);
            int sum = 0;
            int[] multiplier = new int[] { 7, 3, 1 };
            int[] array = new int[inputNumber.Length];
            for (int i = 0; i < inputNumber.Length; i++)
            {
                array[i] = int.Parse(inputNumber[i].ToString());
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[array.Length - 1 - i] * multiplier[i % 3];
            }
            int checkNumber = 10 - (sum % 10);
            if (checkNumber == 10)
            {
                checkNumber = 0;
            }
            string outputNumber = inputNumber + checkNumber;
            for (int i = 1; i < outputNumber.Length; i++)
            {
                if (i % 5 == 0)
                {
                    outputNumber = outputNumber.Insert(i, "");
                }
            }
            Console.WriteLine($"Uusi viitenumero: {outputNumber}");
            Console.WriteLine("\nPaina jotain näppäintä palataksesi alkuun");
            Console.ReadLine();
            Console.Clear();
        }

        static void CreateMultiNumber()
        {
            Console.Clear();
            Console.Write("Kuinka monta viitenumeroa haluat luoda?: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Mikä on viitenumeron alkuosa? (3-19 numeroa): ");
            string baseNumber = Console.ReadLine();


            int i = 0;
            //string path = @"Referencenumber.txt";



            for (int i2 = 0; i2 < count; i2++)
            {


                if ((CheckNumber(baseNumber + i) == true))
                {
                    Console.WriteLine($"Uusi viitenumero on {baseNumber}{i}");
                    //WriteToFile(path, baseNumb + i);
                    i++;

                }
                else
                {
                    i++;
                    i2--;
                }

            }

        }
        //static void WriteToFile(string path, string inputValue)
        //{
        //    using StreamWriter sw = new StreamWriter(path, true);
        //    sw.WriteLine(inputValue);
        //}
    }
}