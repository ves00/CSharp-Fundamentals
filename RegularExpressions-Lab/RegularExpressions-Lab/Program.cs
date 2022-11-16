using System;
using System.Text.RegularExpressions;

namespace RegularExpressions_Lab
{
    internal class Program
    {
        static void Main()
        {
            string pattern = @"(\w+)";
            string input = "Vesko333###@90awd";
            Regex regex = new Regex(pattern);
            //bool isMatch = regex.isMatch(input);
            Match match = regex.Match(input);
            Console.WriteLine(match.Groups[1]);
        }
    }
}
