using System;
using System.IO;

class Test
{
    public static void Main()
    {
        string path = @"c:\temp\testikirjoitus.txt";
        //if (!File.Exists(path))
        {
            // Create a file to write to.
            DateTime dateTime = new DateTime();
            using (StreamWriter sw = File.CreateText(path)) //appendText tai createtext
            {
                sw.WriteLine($"{dateTime.Date}-------------- ")
                sw.WriteLine("jaa");
                sw.WriteLine("And");
                sw.WriteLine("joo");
            }
       // }

        // Open the file to read from.
        using (StreamReader sr = File.OpenText(path))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}