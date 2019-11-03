using System;

namespace toisto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa 20 satunnaista kokonaislukua väliltä 0-50.\nLuvut tulostetaan viidelle riville pilkulla eriteltynä.\n");
            
            for (int line = 1; line <= 5; line++)
            {
                Console.Write("{0}. rivi: ", line);
                for (int n = 1; n <= 5;)
                {
                    Random rnd = new Random();
                    if (n == 5)
                    {
                        Console.Write("{0}\n", rnd.Next(51));
                        break;
                    }
                    else
                    {
                        Console.Write("{0},", rnd.Next(51));
                        n++;
                    }
                }
            }
        }
    }
}