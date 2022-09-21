using System;

namespace _01.ConvertMeterstoKilometers
{
    class Program
    {
        static void Main()
        {

            int meters = int.Parse(Console.ReadLine());
            float kilomters = meters / 1000.0f;
            Console.WriteLine($"{kilomters:f2}");

        }
    }
}
