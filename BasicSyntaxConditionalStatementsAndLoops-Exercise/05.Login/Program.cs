using System;

namespace _05.Login
{
    class Program
    {
        static void Main()
        {
            string username = Console.ReadLine();

            string password = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currCh = username[i];
                password += currCh;
            }

            int totalTries = 1;
            string enteredPassword;
            while ((enteredPassword = Console.ReadLine()) != password)
            {
                //Wrong password is entered

                if (totalTries >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                totalTries++;
            }
            //Corret password  OR Blocked user
            if (totalTries < 4)
            {
                //Correct password
                Console.WriteLine($"User {username} logged in.");
            }

        }
    }
}
