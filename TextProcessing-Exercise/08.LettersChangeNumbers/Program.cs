using System;

namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main()
        {
            //step 1 reading the input 
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); // => [ A12b, s17G]
            double sum = 0;
            // step 2 foreach through all the results in the array and do mathematical adding, subtracting, dividing and multiplying
            foreach (string item in input)
            {
                char firstLetter = item[0]; //A
                char lastletter = item[^1]; //this is the same as item.length -1 ==> b
                string numAsAtring = item[1..^1]; //this will give us everything that's between 0 and the last index => 12
                double numFromString = double.Parse(numAsAtring); //12
                if (char.IsUpper(firstLetter))
                {
                    int positionOfTheLetter = firstLetter - 64;
                    numFromString /= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = firstLetter - 96;
                    numFromString *= positionOfTheLetter;
                }

                if (char.IsUpper(lastletter))
                {
                    int positionOfTheLetter = lastletter - 64;
                    numFromString -= positionOfTheLetter;
                }
                else
                {
                    int positionOfTheLetter = lastletter - 96;
                    numFromString += positionOfTheLetter;
                }
                sum += numFromString;
            }
            //step 3 print the result on the console
            Console.WriteLine($"{sum:f2}");
        }
    }
}
