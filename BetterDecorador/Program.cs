using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor("Good Morning!" , '*', 3));
            Console.WriteLine(Decor("Good Evening!" , '.', 3));
        }

        private static string Decor( string s , char dec, int ntimes)
        {
            string stringdecor = "";

            for (int x = 0; x < ntimes; x++)
            {
                stringdecor += dec;
            }
           
            return $"{stringdecor} {s} {stringdecor}";

        }
    }
}
