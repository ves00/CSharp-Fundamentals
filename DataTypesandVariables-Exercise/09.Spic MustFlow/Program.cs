using System;

namespace _09.Spic_MustFlow
{
    class Program
    {
        static void Main()
        {
            int spice = int.Parse(Console.ReadLine());

            int countDays = 0;
            int totalSpice = 0;

            while (spice >= 100)
            {
                countDays++;
                totalSpice += spice - 26;
                spice -= 10;
            }

            if (totalSpice > 26)
            {
                totalSpice -= 26;
            }
            else
            {
                totalSpice -= totalSpice;
            }

            Console.WriteLine(countDays);
            Console.WriteLine(totalSpice);
        }
    }
}

