using System;

namespace hetu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("ohjeelma tarkistaa hetun");
            char userChoise;
            do
            {
                Console.Clear();
                userChoise = UserInterface(); //käyttöliittymä funktio
                switch (userChoise)
                {
                    case 'T':
                        SSNChecker();
                        break;
                    case 'U':
                        //SSNCreator(); //kutsutaan sotunluonti optiota
                        break;
                    case 'X':
                        break;
                    default:
                        Console.WriteLine("Tarkista mitä painoit! Enter jatkaa ohjelmaa");
                        Console.ReadKey();
                        break;

                }
            } while (userChoise != 'X');
        }
        static void SSNCreator()
        {
            Console.Write("\nAnna luotavan sotun alkuosa [PPKKVV-XXXT]: ");
            string userInput = Console.ReadLine();

            userInput = RemoveSpaces(userInput);
            if (IsValidLenght(userInput, 10))
            {
                if (IsValidDate(userInput))
                {
                    int idNumber = InputParse(userInput);
                    char getValidationMark = GetValidationMark(idNumber);
                    PrintCreatedSSNUmber(userInput + getValidationMark);
                }
            }
        }


        static void SSNChecker()
        {
            Console.Write("\nAnna tarkastettava sotu [PPKKVV-XXXT]: ");
            string userInput = Console.ReadLine();

            userInput = RemoveSpaces(userInput);
            if (IsValidLenght(userInput))
            {
                if (IsValidDate(userInput))
                {

                    int idNumber = InputParse(userInput);
                    char getLastChar = GetUserInputChkMark(userInput);
                    bool isOK = isValidID(idNumber, getLastChar);
                    printresult(isOK);
                }
            }
            else
            {
                Console.WriteLine("tarkasta hetun oikeellisuus -liikaa merkkejä");
            }
        }

        static char UserInterface()
        {
            Console.WriteLine("Henkilötunnuksen käsittely");
            Console.WriteLine("[T] Tarkista henkilötunnuksen oikeellisuus");
            Console.WriteLine("[U] Luo uusi henkilötunnus");
            Console.WriteLine("[X] Sulje ohjelma");
            Console.Write("Valitse mitä tehdään: ");

            return char.ToUpper(Console.ReadKey().KeyChar);
        }
        static bool IsValidDate(string userInput)
        {
            //131052-308T
            bool result = false;
            //
            string day = userInput.Substring(0, 2);
            string month = userInput.Substring(2, 2);
            string year = userInput.Substring(4, 2);
            string century = userInput.Substring(6, 1);

            if (century == "-")
            {
                year = "19" + year;
            } 
            else if (century == "A")
            {
                year = "20" + year;
            }
            else
            {
                Console.WriteLine("väärä vuosisata");
            }
            //Tarkistetaan päivämäärä oikeellisuus try-catch lohkossa
            try
            {
                DateTime birthday = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return result;
        }

        static bool IsValidLenght(string userInput)
        {
            return userInput.Length == 11;
            //if (userInput.Length == 11)
              //  return true;
            //else
              //  return false;
        }
        static bool IsValidLenght(string userInput, int lenght)
        {
            return userInput.Length == lenght;
        }

            static string RemoveSpaces(string userInput)
        {
            string result = userInput.Replace(" ", "");
            return result;
        }

        static char GetUserInputChkMark(string userInput)
        {
            return userInput[userInput.Length - 1];
        }

        static int InputParse(string stringParser)
        {
            //luetaan
            //string result = stringParser.Substring(0, 5);
            string removed = userInput;
            if (stringParser.Length > 10)
            {
                removed = stringParser.Remove(10, 1);
            }
            
            removed = removed.Remove(6, 1);

            return int.Parse(removed);
        }

        static bool isValidID(int idNumber, char userInputCheckMark)
        {
            string checkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";

            int modCheck = idNumber % 31;

            //Vertailu onkokäyttäjän syöttämä viimeinen merkki sama kuin laskettu
            //if (checkMark[modCheck] == userInputCheckMark)
            //    return true;
            //else
            //    return false;

            //Console.WriteLine(checkMark[modCheck]);
            return checkMark[modCheck]== userInputCheckMark;
        }
        static bool GetValidationMark(int idNumber, char userInputCheckMark)
        {
            string checkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";

            int modCheck = idNumber % 31;
            return checkMark[modCheck];
        }

            static void printresult(bool isValidID)
        {
            if(isValidID)
                Console.WriteLine("Sotu on oikea");
                else
                Console.WriteLine("Sotu on väärä");
        }
        static void PrintCreatedSSNUmber(string newSSNumber)
        {
            Console.WriteLine($"Luotu sotu on: {newSSNumber} ");
        }
    }
}
