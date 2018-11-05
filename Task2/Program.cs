using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            bool div = num % 35 == 0 ? true : false;
            if (div)
            {
                Console.WriteLine("The number is divadible by both 5 and 7.");
            }
            else
            {
                Console.WriteLine("The number is not divadible by 5 and 7.");
            }


            Console.ReadLine();
        }

    }
}
