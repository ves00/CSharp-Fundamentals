using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double cources = Math.Ceiling((double)people / capacity);
            
            Console.WriteLine(cources);
        }
    }
}
