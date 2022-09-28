using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main()
        {
          string[] chars = Console.ReadLine()
               .Split()
               .ToArray();

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                Console.Write($"{chars[i]} ");
            }
        }
    }
}
