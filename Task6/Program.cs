using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("S={0}, P={1}", a * b, (a + b) * 2);
            Console.ReadLine();
        }
    }
}
