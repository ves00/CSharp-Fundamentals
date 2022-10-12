﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main()
        {

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            bool isChecked = false;

            while (input != "end")
            {
                //Add 3
                //Remove 4...
                string[] inputParams = input.Split();

                string command = inputParams[0];

                if (command == "Add")
                {
                    isChecked = true;
                    int value = int.Parse(inputParams[1]);
                    numbers.Add(value);
                }
                else if (command == "Remove")
                {
                    isChecked = true;
                    int value = int.Parse(inputParams[1]);
                    numbers.Remove(value);
                }
                else if (command == "RemoveAt")
                {
                    isChecked = true;
                    int value = int.Parse(inputParams[1]);
                    numbers.RemoveAt(value);
                }
                else if (command == "Insert")
                {
                    isChecked = true;
                    int value = int.Parse(inputParams[1]);
                    int index = int.Parse(inputParams[2]);

                    numbers.Insert(index, value);
                }
                else if (command == "Contains")
                {
                    int value = int.Parse(inputParams[1]);
                    if (numbers.Contains(value))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (command == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command == "Filter")
                {
                    string condition = inputParams[1];
                    int value = int.Parse(inputParams[2]);

                    if (condition == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < value)));
                    }
                    else if (condition == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= value)));
                    }
                    else if (condition == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > value)));
                    }
                    else if (condition == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= value)));
                    }
                }

                input = Console.ReadLine();
            }
            if (isChecked)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
