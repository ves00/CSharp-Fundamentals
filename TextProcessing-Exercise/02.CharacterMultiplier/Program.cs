using System;

namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main()
        {
            //step 1 Converting string inpuut "Peter George" in string[] => ["Peter", "George"] by using Split();
            //step 2 Creating a method that takes two arguments string input[0] and input[1];
            //step 3 Create integer sum = 0 in which we will save the final sum of  multiplication/ adding if the one string is longer then the other
            //step 4 Finding string that is bigger than the other Math.Min(stringOne.length, stringTwo.lenght)
            //step 5 create for loop string from 0 till the minLength to go trought both strings
            string[] input = Console.ReadLine().Split();
            GetStringSum(input[0], input[1]);
        }

        private static void GetStringSum(string stringOne, string stringTwo)
        {
            int sum = 0;
            int minLength = Math.Min(stringOne.Length, stringTwo.Length);
            for (int i = 0; i < minLength; i++)
            {
                sum += stringOne[i] * stringTwo[i];
            }

            string longestLengthString = stringOne;
            if (longestLengthString.Length < stringTwo.Length)
            {
                longestLengthString = stringTwo;
            }
            for (int i = minLength; i < longestLengthString.Length; i++)
            {
                sum += longestLengthString[i];
            }
            Console.WriteLine(sum);
        }
    }
}
