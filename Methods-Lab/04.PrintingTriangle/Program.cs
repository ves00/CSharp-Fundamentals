﻿using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++) //rows
            {
                PrintColumns(i);
            }

            for (int i = number - 1; i >= 1; i--) //rows
            {
                PrintColumns(i);
            }
        }
        private static void PrintColumns(int i)
        {
            for (int j = 1; j <= i; j++) //cols
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
