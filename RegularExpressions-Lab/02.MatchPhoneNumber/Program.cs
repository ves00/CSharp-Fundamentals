using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main()
        {
            // \+\b359(-| )2\1\d{3}\1\d{4}\b
            string patern = @"\+\b359(-| )2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(patern);
            MatchCollection matchCollection = regex.Matches(input);
            /*
            foreach (Match match in matchCollection)
            {
                Console.WriteLine(match.Value + ",");
            }*/
            string[] result = matchCollection.Select(x => x.Value).ToArray();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
