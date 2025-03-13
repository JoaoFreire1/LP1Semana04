using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            string sinput = Console.ReadLine();
            int input = int.Parse(sinput);
            int result = GetSpecial(input);    
            Console.WriteLine(result); 
        }

        private static int GetSpecial (int n) 
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
    
            return GetSpecial(n-1) + (GetSpecial(n-2) * 2);
        }
            
    }
}
