using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split() // .Split() == .Split(' ')
                .Select(int.Parse)
                .ToList();

            //1st way
            /* for (int i = 0; i < numbers.Count; i++)
             {
                 if (numbers[i] < 0)
                 {
                     numbers.Remove(numbers[i]);
                     i--;
                 }
             }*/


            // numbers.RemoveAll(x => x < 0); //2th way


            //3th way does not work becuse we cant remove elements with foreach !!!Error
            /* foreach (var number in numbers)
             {
                 if (number < 0)
                 {
                     numbers.Remove(number);
                 }
             }*/

            numbers.Reverse();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
