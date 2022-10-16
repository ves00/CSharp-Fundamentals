using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exercise
{
    class Program
    {
        static void Main()
        {
            //Demo 01--------------------------

            List<int> numbers = new List<int>()
            {
                1, 2, 3, 4
            };
            numbers.Add(5); //Adding element at the end of the list!!! (change indexes in the list)
            numbers.Remove(1); //Removing element by its value (will remove the first 1 in the list, will change indexes in the list)
            numbers.RemoveAt(1); //Removing element by its index (keep int mind that indexes may be changet)
            numbers.Insert(0, 1); //Insert element ON this index
            numbers.AddRange(new int[] { 6, 7, 8 }); //Easy append one collection into another
            Console.WriteLine(numbers.Contains(2));
            numbers[2] = 100; //List<T> is mutable

            //n => ...(Lambda expresion,inline method without a name, accept n, return ...)
            List<int> evenNumbers = numbers
                .Where(n => n % 2 == 0)
                .ToList();

            Console.WriteLine(string.Join(" ,", numbers));
        }

    }
}
