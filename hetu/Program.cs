using System;

namespace hetu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ohjeelma tarkistaa hetun");
            //Console.Write("");
            string userInput = "101098-593V";
            int idNumber = InputParse(userInput);
            isValidID(idNumber);


            

        }



        static int InputParse(string stringParser)
        {
            //luetaan
            string result = stringParser.Substring(0, 5);

            string removed = stringParser.Remove(10, 1);
            removed = removed.Remove(6, 1);

            return int.Parse(removed);
        }

        static bool isValidID(int idNumber)
        {
            string checkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";

            int modCheck = idNumber % 31;

            Console.WriteLine(checkMark[modCheck]);
            return true;

        }
    }
}
