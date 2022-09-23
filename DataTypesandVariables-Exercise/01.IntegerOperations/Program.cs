using System;
using System.Numerics;

namespace _01.IntegerOperations
{
    class Program
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            long result1 =(long) n1 + n2;
            long result2 = result1 / n3;
            long finalResult =  result2 * n4;

            Console.WriteLine(finalResult);


        }
    }
}
