﻿using System;

namespace P04.BackIn30Minutes
{
    class Program
    {
        static void Main()
        {

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 30;
            if (minutes > 59)
            {
                hours += 1;
                minutes -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            Console.WriteLine("{0}:{1:D2}", hours, minutes);
        }
    }
}
