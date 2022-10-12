using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Lab
{
    class Program
    {
        static void Main()
        {
            //Demo 01------------------------

            /*  List<string> names = new List<string>();

              names.Add("Veselin");
              names.Add("Veselinov");

              names.Insert(1, "SoftUni");

              for (int i = 0; i < names.Count; i++)
              {
                  Console.WriteLine(names[i]);
              }

              Console.WriteLine("-----------------------");

              names.Remove("Veselinov");

              for (int i = 0; i < names.Count; i++)
              {
                  Console.WriteLine(names[i]);
              }*/


            //Demo 02------------------------

            /* List<int> numbers = new List<int>
             { 10, 20, 30, 40, 50, 60 };
             numbers.Remove(30);
             numbers.Add(100);
             numbers.Insert(0, -100);

             //First way
              for (int i = 0; i < numbers.Count; i++)
              {
                  Console.Write(numbers[i] + " ");
              }

             //Second way
            // Console.WriteLine(string.Join(" ", numbers));*/

            //Demo 03------------------------

            /* int[] numbers = new int[] { 10, 20, 30 };

             List<int> nums = new List<int>();
             nums.Add(20);

             int[] numbersArray = new int[numbers.Length + 1];


             for (int i = 0; i < numbers.Length; i++)
             {
                 numbersArray[i] = numbers[i];
             }

             numbersArray[numbers.Length - 1] = 20;*/

            //Demo 04-----------------------
            /* List<int> numbers = new List<int> { 10, 20, 30, 20, 40 };

             numbers.Remove(20);

             Console.WriteLine(string.Join( Environment.NewLine, numbers));*/


            //Demo 05-----------------------
            /*List<int> inputNumbers =
                Console.ReadLine() //" 12 3 5"
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToList();

            //First way 
            // for(int i = 0; i < inputNumbers.Count; i++)
            // {
            //   Console.WriteLine(inputNumbers[i]);
            //  }

            //Second way
            foreach (var number in inputNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(string.Join(" ", inputNumbers));*/

            //Demo 06-----------------------
            /*  List<int> numbers = new List<int>
              { 5, 1, 40, -4, 200, 10};

              numbers.Sort();
              Console.WriteLine(string.Join(" ", numbers));

              Console.WriteLine("-----------------------");

              numbers.Reverse();
              Console.WriteLine(string.Join(" ", numbers));*/

        }
    }
}
