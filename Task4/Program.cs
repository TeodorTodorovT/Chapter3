using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write an expression that checks whether the third bit in a given integer is 1 or 0.
            int number = 456;
            Console.WriteLine("The third bit of {0} is 1? {1}", number, ((number >> 3) & 1) == 1);
            Console.ReadLine();
        }
    }
}
