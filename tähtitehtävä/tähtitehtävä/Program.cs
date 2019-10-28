using System;

namespace tähtitehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaaa syötetyn numeron mukaisen määrän tähtiä. ");
            Console.Write("Syötä luku.");
            int userInput = int.Parse(Console.ReadLine());
            string strStars = GenerateAmountOfStars(userInput);
            Console.WriteLine(strStars);


        }

        ///<summary>
        ///Ohjelma generoi parametrin määrän tähtiä
        ///</summary>
        ///<param name="starCounter"></param>
        ///<returns></returns>
        
        static string GenerateAmountOfStars(int starCounter)
        {
            string stars = "";
            for(int i = 0; i<starCounter; i++)
            {
                stars = stars + "*";
                //stars += "*"
            }
            return stars;

        }

    }
}
