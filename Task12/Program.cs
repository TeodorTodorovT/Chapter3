using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a Boolean expression that checks if the bit on position p in the integer v has the value 1. Example v=5, p=1 -> false.
            int v = 350;
            int p = 350;
            int mask = 1 << p;
            bool isOne = (v & mask) != 0 ? true : false;
            Console.WriteLine("The bit at position {0}of number {1} is 1? {2}", p, v, isOne);
        }
    }
}
