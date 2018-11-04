using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write an expression that checks whether an integer is odd or even.
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
            Console.ReadLine();
        }  

    }
}
