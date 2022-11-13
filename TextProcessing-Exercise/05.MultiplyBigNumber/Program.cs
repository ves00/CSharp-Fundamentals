using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();  //23
            int multiplier = int.Parse(Console.ReadLine()); //2
            var sb = new StringBuilder(); //create empty StringBuilder which will give us a method that we can use to build our string
            int reminder = 0;
            //safeguard  if the user tries something funny or forbidden
            if (multiplier == 0 || input == "0")
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--) // 23 ==> 32
            {
                int currDigit = int.Parse(input[i].ToString()); // 3
                int product = currDigit * multiplier + reminder;
                int result = product % 10; // 32 / 10 => 2
                reminder = product / 10;
                sb.Insert(0, result);
            }

            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
