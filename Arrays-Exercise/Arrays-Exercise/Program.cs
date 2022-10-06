using System;
using System.Linq;

namespace Arrays_Exercise
{
    class Program
    {
        static void Main()
        {
            //Demos
            //Dynamic Length - Choosed by user input
            //Cannot be changet after input
            int[] numbers = Console.ReadLine()
                 .Split(", ") //string[]
                  .Select(int.Parse) //UnkownCollection<int>
                  .ToArray(); //int[]



            //  int n = int.Parse(Console.ReadLine());

            //Edge case
            /* char[] str = new char[n];

           str[0] = 'H';
           str[1] = 'e';
           str[2] = 'l';
           str[3] = 'l';
           str[4] = 'o';

           Console.WriteLine(str);*/


            //int[] numbers = new int[5];
            /*numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;*/

            //Printing array direct -> Print type of the variable
            /*Console.WriteLine(string.Join("\n", numbers));*/
            //Benefit -> know the index of element, reverse reading
            for (int i = 0; i < numbers.Length; i++)
            {
                int curreNum = numbers[i];
                Console.WriteLine($"Index {i}  -> {curreNum}");
            }
            Console.WriteLine("-------------------------------");

            //Reverse reading
            //Type 1
            /* for (int i = numbers.Length -1; i >= 0; i--)
             {
                 int curreNum = numbers[i];
                 Console.WriteLine($"Index {i}  -> {curreNum}");
             }*/

            //Type 2
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[numbers.Length - i - 1];
                Console.WriteLine($"Index {numbers.Length - i - 1}  -> {currNum}");
            }

            //Benefit -> Less code easy to use no indexes
            foreach (int num in numbers)
            {
                Console.WriteLine(num);

            }

            //-----------------------------
            //Read array from the console
            int[] numBers = Console.ReadLine()
                 .Split(", ") //string[]
                  .Select(int.Parse) //UnkownCollection<int>
                  .ToArray(); //int
            //For  string 
            string[] strs = Console.ReadLine()
                .Split(" ");

            //Copy the  numbers into another array
            //Own copy algorithm
            int[] copyArray = new int[numBers.Length];
            /* for (int i = 0; i < numbers.Length; i++)
             {
                 int currNum = numbers[i];
                 copyArray[i] = currNum;
             }*/


            //Not prefered
            Array.Copy(numBers, copyArray, numBers.Length);

            Console.WriteLine(String.Join(" ", copyArray));
        }
    }
}

