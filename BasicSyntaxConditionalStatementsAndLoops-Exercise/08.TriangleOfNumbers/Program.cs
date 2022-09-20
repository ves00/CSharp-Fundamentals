using System;

namespace _08.TriangleOfNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //Using for loop - to loop N times
            //Outer loop represents rows 
            for (int row = 1; row <= n; row++)
            {

                //Nested loop represents columns
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{row} ");
                }

                //Console new row
                Console.WriteLine();
            }

        }
    }
}
