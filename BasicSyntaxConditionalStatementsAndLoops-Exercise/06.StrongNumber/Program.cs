using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            //Modular division by 10-> return last digit
            //Integer dibision by 10-> removes last digit
            int numCopy = n;
            int factorialSum = 0;
            while (numCopy > 0)
            {

                /* n += 1; // add on one -> n = n + 1;
                 n -= 1; //Subtract one -> n = n-1;
                 n *= 2; //multiply by two -> n = n * 2;
                 n /= 10; //divide by ten -> n = n/10;*/
                int lastDigit = numCopy % 10;  //Take last digit
                numCopy /= 10;  // Removes the taken digit

                //Calculate factorial of the last digit 
                //Stores a product  -> starts 1 --> 1 * n = n; 0 * n = 0 (wrong)
                int factorial = 1;              //Sum -> start from 0  || Product -> start from 1
                for (int i = 2; i <= lastDigit; i++)
                {
                    factorial *= i;  //factorial = factorial * i;
                }

                //Summing factorial
                factorialSum += factorial;

            }

            if (factorialSum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
