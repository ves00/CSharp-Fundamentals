using System;

namespace Methods_Lab
{
    class Program
    {
        static void Main()
        {
            //Demo 01 ------------
            /*  int[] eggs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

              Console.WriteLine(eggs.Length);

              for (int i = 0; i < eggs.Length; i++)
              {
                  int test = eggs.Length;
                  int test2 = eggs.Length - 1;
                  int test3 = i;
                  /*eggs[i] = eggs[i] + 3;
                  Console.WriteLine(eggs[i]);
              }*/
            // NewWord(); //Demo 02 --------


            //int absValue = Math.Abs(-10);

            //Demo 04 -------------
            /* string name = "NewName";
             Greeting(name);*/


            //Demo 05 ------------
            /* for (int i = 1; i <= 100; i++)
             {
                 Console.Write(i + " ");
             }
             for (int i = 3; i <= 33; i++)
             {
                 Console.Write(i + " ");
             }
             for (int i = 5; i <= 25; i++)
             {
                 Console.Write(i + " ");
             }*/
            /* PrintNumbers(1, 100);
             Console.WriteLine();
             PrintNumbers(3, 33);
             Console.WriteLine();
             PrintNumbers(5, 25);*/

            //Demo 06 ------------
            /*  int number = int.Parse(Console.ReadLine());
              PrintTypeOfNumber(number);*/


            //Demo 07 --------------------
            /* PrintNumbers(34289, 7653);*/

            //Demo 08 -----------------
            /*     int number = 15;
                 IncrementNumber(number);
                 Console.WriteLine(number);
                 int[] numbers = new int[] { 15 };
                 IncrementArray(numbers);
             }

             private static void IncrementArray(int[] numbers)
             {
                 IncrementArray(numbers);
             }

             private static void IncrementNumber(int number)
             {
                 number += 5;
             }*/

            //Demo 09 -----------------
            /*  string firstName = Console.ReadLine();
              string lastName = Console.ReadLine();
              string fullName = Concatenate(firstName, lastName);

              Console.WriteLine(fullName);*/
            //Demo 10 --------------------------
            Console.WriteLine(GetInt() * 2);
        }
        //Demo 04-----------
        /* static void Greeting(string name)
         {
             string greetings = $"Hello, {name}!";
             Console.WriteLine(greetings);
         }*/

        //Demo 02 ---------
        /*  static void NewWord()
          {
              Console.WriteLine("Wellcome to the new advanture!");

            NewDay(); //Demo 03 ---------------
          }
        static void NewDay()
        {
            Console.WriteLine("Day 1");
        }*/

        //Demo 05 ------------
        /* static void PrintNumbers(int start, int end)
         {
             for (int i = start; i < end; i++)
             {
                 Console.Write(i + " ");
             }
         }*/

        //Demo 06 ------------
        /*  static void PrintTypeOfNumber(int number)
          {
              if (number > 0)
              {
                  Console.WriteLine($"The number {number} is positive.");
              }
              else if (number < 0)
              {
                  Console.WriteLine($"The numbeer {number} is negative");
              }
              else
              {
                  Console.WriteLine($"The number is 0.");
              }
          }*/

        //Demo 07 --------------------
        /* static void PrintNumbers(int a = -1, int b =-1)
         {
             Console.WriteLine($"{a} - {b}");
         }*/

        //Demo 09 -----------------
        /*  static string Concatenate(string firstName, string lastName)
          {
              string fullName = firstName + " " + lastName;
              return fullName;
          }*/

        //Demo 10 --------------------------
        static int GetInt()
        {
            //logic
            return 5;
        }
    }
}
