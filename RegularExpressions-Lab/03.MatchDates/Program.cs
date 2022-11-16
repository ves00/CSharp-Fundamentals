using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main()
        {
            // (?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})
            string pattern = @"(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);
            foreach (Match match in matchCollection)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

                /*
                string day = match.Groups[0].Value;
                string day1 = match.Groups[1].Value;
                string day2 = match.Groups[2].Value;
                string day3 = match.Groups[3].Value;
                string day4 = match.Groups[4].Value;
                Console.WriteLine(day);
                Console.WriteLine(day1);
                Console.WriteLine(day2);
                Console.WriteLine(day3);
                Console.WriteLine(day4);
                Console.WriteLine();
                */
            }
        }
    }
}
