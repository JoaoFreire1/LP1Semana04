using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(args[0]);
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
