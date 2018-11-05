using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());
            bool isInsideCircle = (x * x + y * y <= 5) ? true : false;
            bool isOutsideRectangle = (x < -1 && x > 5 && y < 1 && y > 5) ? true : false;
            Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}", x, y, isInsideCircle);
            Console.WriteLine("The point O({0},{1}) is outside rectangle ((-1, 1), (5, 5)?: {2}", x, y, isOutsideRectangle);
            Console.ReadLine();
        }
    }
}
