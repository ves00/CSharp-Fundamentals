﻿using System;

namespace P03.PassedorFailed
{
    class Program
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade > 2.99)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
