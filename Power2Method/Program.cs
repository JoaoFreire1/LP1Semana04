using System;

namespace Power2Method
{
    

    class Program
    {
        
        private static void Powersof2Until5()
        {
        for (int i = 1; i <= (1<<5); i = i << 1)
        {
            Console.WriteLine(i);
        }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Powersof2Until5();
            Powersof2Until5();
        }
    }
}
