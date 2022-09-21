using System;

namespace _02.PoundstoDollars
{
    class Program
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            double resultt = num * 1.31;
            Console.WriteLine($"{resultt:f3}");
        }
    }
}
