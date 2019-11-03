using System;

namespace toisto6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma heittää noppaa.\n");

            int six = 0;

            for (int line = 1; line <= 1000; line++)
            {
                Random rnd = new Random();
                int result = rnd.Next(6);
                Console.WriteLine($"{line}. \t{result + 1}");

                if (result + 1 == 6)
                {
                    six++;
                }
            }
            Console.Write($"\nKutonen arvottiin {six} kertaa.\n");
        }
    }
}
