using System;
using System.Linq;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main()
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int[] numbers = new int[3] { num1, num2, num3 };

            SmallerNumber(numbers);
        }
        private static void SmallerNumber(int[] numbers)
        {
            Console.WriteLine(numbers.Min());
        }
    }
}
