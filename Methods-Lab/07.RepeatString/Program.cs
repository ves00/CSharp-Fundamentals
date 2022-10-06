using System;
using System.Text;

namespace _07.RepeatString
{
    class Program
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeatString(inputStr, count);
            Console.WriteLine(result);
        }
        private static string RepeatString(string str, int count)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
                result.Append(str);
            return result.ToString();
        }
    }
}
