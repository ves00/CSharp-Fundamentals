using System;

namespace _09.CharstoString
{
    class Program
    {
        static void Main()
        {
            char[] chars = new char[3];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = char.Parse(Console.ReadLine());
            }

            Console.Write(string.Join("", chars));
        }
    }
}
