using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write an expression that calculates the area of a trapezoid by given sides a, b and height h.
            int a = 2;
            int b = 3;
            int h = 1;
            Console.WriteLine("S={0}", (a + b) / (2 * h));
        }
    }
}
