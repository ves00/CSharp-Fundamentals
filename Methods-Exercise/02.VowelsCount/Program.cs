using System;
using System.Linq;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main()
        {
            //1 way -> void Method (string text) -> Console.WriteLine()
            //2 way -> int Method (string text) -> Main: Console.WriteLIne(); //Mostly used
            string text = Console.ReadLine();
            int vowelsCount = GetVowelsCount(text);
            Console.WriteLine(vowelsCount);
        }

        static int GetVowelsCount(string text)
        {
            int vowelsCount = 0;
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'y' };
            foreach (char letter in text.ToLower())
            {
                if (vowels.Contains(letter))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}