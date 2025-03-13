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
            /// <summary>
            /// Checks if args lenght is correct
            /// </summary>
            /// <param name="args"></param>
            /// <returns>string</returns>
            if (args.Length != 3)
            {
                Console.WriteLine(Decor());
                return;
            }

            char c = char.Parse(args[1]);
            int n = int.Parse(args[2]);
            Console.WriteLine(Decor(args[0], c, n));
            return;
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

        /// <summary>
        /// Recursive function in case of fail
        /// </summary>
        /// <returns> Decor function with established string</returns>
        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }
    }
}
