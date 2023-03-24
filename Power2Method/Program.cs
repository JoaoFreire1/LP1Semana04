using System;

namespace Power2Method
{
    private static void Powersof2Until5()
    {
        for (int i = 1; i <= (1<<5); i = i << 1)
        {
            Console.WriteLine(i);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
