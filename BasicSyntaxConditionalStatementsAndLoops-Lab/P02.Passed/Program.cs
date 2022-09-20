using System;

namespace P02.Passed
{
    class Program
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
