﻿using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {   //task: Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:
            // -     Calculates the sum of the digits (in our example 2+0+1+1 = 4).
            // -     Prints on the console the number in reversed order: dcba (in our example 1102).
            // -     Puts the last digit in the first position: dabc (in our example 1201).
            // -     Exchanges the second and the third digits: acbd (in our example 2101).
            Console.Write("Enter a four-digit number: ");
            int number = int.Parse(Console.ReadLine());
            int a = number / 1000;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;

            Console.WriteLine("The sum of digits is {0}", a + b + c + d);
            Console.WriteLine("The digits backwards {3}{2}{1}{0}", a, b, c, d);
            Console.WriteLine("Last digit on first place {3}{0}{1}{2}", a, b, c, d);
            Console.WriteLine("Replace third and second digit = {0}{2}{1}{3}", a, b, c, d);
            Console.ReadLine();
        }
    }
}
