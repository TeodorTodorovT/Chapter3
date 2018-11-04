using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {   //task: The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
            Console.Write("Enter weight of a person: ");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("This person will weight {0}kg on the Moon.", weight * 0.17);
            Console.ReadLine();
        }
    }
}
