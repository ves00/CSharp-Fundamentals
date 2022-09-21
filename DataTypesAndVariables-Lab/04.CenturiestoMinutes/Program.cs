using System;

namespace _04.CenturiestoMinutes
{
    class Program
    {
        static void Main()
        {
            //1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
            //365.2422

            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
