using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the x of the point (A): ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the y of the point (A): ");
            int y = int.Parse(Console.ReadLine());
            bool isInside = (x * x + y * y <= 25) ? true : false;
            if (isInside == true)
            {
                Console.WriteLine("The point (A) you entered is within the circle K[{0, 0}, R=5]");
            }
            else
            {
                Console.WriteLine("The point (A) you entered is not within the circle K[{0, 0}, R=5]");       
            }

            Console.ReadLine();
        }
    }
}
