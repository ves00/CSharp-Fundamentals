using System;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main()
        {
            // step 1 = Reading the input from the console
            string text = Console.ReadLine();

            // Step 2 => text = aaaabbbccc => previousCahr = text[0]
            char previousChar = text[0];  //'a'
            Console.WriteLine(previousChar);
            // step 3 iterate through the text starting 1 index
            for (int i = 1; i < text.Length; i++)
            {
                // Step 4 Take the currentChar and make check with the previous
                char currentChar = text[i];
                if (previousChar != currentChar) // a != b then previousChar = b
                {
                    previousChar = currentChar;
                    Console.Write(previousChar);  //'ab'
                }

            }


        }
    }
}
