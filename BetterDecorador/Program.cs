using System;

namespace BetterDecorador
{
    /// <summary>
    /// Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main function, send strings to Decor function
        /// </summary>
        /// <param name="args">Console Arguments</param>
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor("Good Morning!" , '*', 3));
            Console.WriteLine(Decor("Good Evening!" , '.', 3));
        }

        /// <summary>
        /// Decorates sentences
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="num"></param>
        /// <returns>A string, decorated sentence</returns>
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
