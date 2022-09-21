using System;

namespace _10.LowerorUpper
{
    class Program
    {
        static void Main()
        {
            char letter = char.Parse(Console.ReadLine());

            if (letter >= 'a' && letter <= 'z')
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
