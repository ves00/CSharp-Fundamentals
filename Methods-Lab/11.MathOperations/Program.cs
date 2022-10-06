using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main()
        {

            int num1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculator(num1, @operator, num2));
        }
        public static double Calculator(int num1, string @operator, int num2)
        {
            double result = 0;

            switch (@operator)
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "*": result = num1 * num2; break;
                case "/": result = (double)num1 / num2; break;
            }
            return result;
        }
    }
}
