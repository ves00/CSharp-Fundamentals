using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main()
        {
                             // 0,          1        2            3            4        5             6
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int day = int.Parse(Console.ReadLine());

            if (day <= 7 && day > 0)
            {
                Console.WriteLine(days[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
