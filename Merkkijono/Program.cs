using System;

namespace Merkkijono
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä jotain: ");
            string a = Console.ReadLine();
            string lowA = a.ToLower();
            int i = a.Length;
            Console.WriteLine($"\nSyötteessä on {i} merkkiä.");
            

            Console.WriteLine("\nSyötteestä on vaihdettu  e-kirjaimet @-merkiksi.");
            Console.WriteLine(lowA.Replace("e", "@"));

            int n1 = 0;
            for (int n=0; n<a.Length; n++)
            {
                if (a[n]== 'l')
                {
                    n1++;
                }
            }
            Console.WriteLine($"\nL kirjaimia syötteessä oli {n1}\n");
            
            
            int input = 0;
            int output = a.Length - 1;
            bool check = true; 

            for (int iCheck = 0; iCheck < a.Length - 1; iCheck++)
            {
                if (lowA[input] == lowA[output])
                {
                    input++;
                    output--;
                }
                else
                    check = false;
            }
            if (check == true)
            {
                Console.WriteLine($"{a} on palindromi!");
            }
            else
            {
                Console.WriteLine($"{a} ei ole palindromi!");
            }
        }
    }
}
