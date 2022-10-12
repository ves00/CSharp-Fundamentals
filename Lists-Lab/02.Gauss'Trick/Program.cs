using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Gauss_Trick
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            //1 2 3 4 5

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int currentSum = numbers[i] + numbers[numbers.Count - 1 - i];

                result.Add(currentSum);
            }

            if (numbers.Count % 2 != 0)
            {
                result.Add(numbers[numbers.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
