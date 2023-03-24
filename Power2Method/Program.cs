using System;

namespace Power2Method
{
    

    class Program
    {
        
        private static void Powersof2Untiln(int n)
        {
        for (int i = 1; i <= (1<<n); i = i << 1)
        {
            Console.WriteLine(i);
        }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please Write a number!");
            int n = Convert.ToInt32(Console.ReadLine());
            Powersof2Untiln();
            Powersof2Untiln();
        }
    }
}
