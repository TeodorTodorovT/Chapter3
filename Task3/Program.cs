using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write an expression that checks for a given integer if its third digit (right to left) is 7.
            int num = 29753;

            if ((num / 100) % 10 == 7)
            {
                Console.WriteLine("Third digit is 7!");
            }
            else
            {
                Console.WriteLine("Third digit is not 7!");
            }
            Console.ReadLine();
        }

    }
}
