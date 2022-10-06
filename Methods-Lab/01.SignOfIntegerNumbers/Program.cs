using System;

namespace _01.SignOfIntegerNumbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintTypeOfNumber(number);
        }
        static void PrintTypeOfNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
