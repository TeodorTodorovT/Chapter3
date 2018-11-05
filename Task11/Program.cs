using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {   //task: We are given number n and position p. Write a sequence of operations that prints the value of the bit on the position p in the number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.
            int n = 35, p = 5, i = 1, mask = i << p;
            Console.WriteLine((n & mask) != 0 ? "Third bit is 1" : "Third bit is 0");
            Console.ReadLine();
        }
    }
}
