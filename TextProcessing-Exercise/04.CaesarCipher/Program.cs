using System;
using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            // string encryptedString = string.Empty; //"" => empty string
            var ss = new StringBuilder();
            foreach (char currChar in input)
            {
                int currPosition = currChar; // currChar =  "P"  in int => 80
                currPosition += 3;
                // encryptedString += (char)currPosition;
                ss.Append((char)currPosition);  //83 int into char => 'S'
            }
            Console.WriteLine(ss.ToString());
        }
    }
}
