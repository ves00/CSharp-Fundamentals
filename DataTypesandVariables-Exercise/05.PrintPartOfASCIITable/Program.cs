using System;

namespace _05.PrintPartOfASCIITable
{
    class Program
    {
        static void Main()
        {

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            //char -> int / int -> char
            for (int i = n1; i <= n2; i++)
            {

                //We have dnumer value of the character  in our memory
                //We need to cast in order to get visual represantation of the num
                char currCh = (char)i;
                Console.Write(currCh + " ");


            }


        }
    }
}
