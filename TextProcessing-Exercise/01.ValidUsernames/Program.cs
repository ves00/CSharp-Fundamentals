using System;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main()
        {
            //read the input from the console
            string[] usernames = Console.ReadLine().Split(", ");
            //iterate through all the usernames
            foreach (string currName in usernames)
            {
                //sh
                if (currName.Length > 3 && currName.Length <= 16)
                {
                    //check if the userName is valid
                    bool isUserNameValid = true;
                    foreach (char currChar in currName) //=> charrArray = [s, h]
                    {
                        if (!(char.IsLetterOrDigit(currChar) || currChar == '-' || currChar == '_'))
                        {
                            isUserNameValid = false;
                            break;
                        }
                    }
                    if (isUserNameValid)
                    {
                        Console.WriteLine(currName);
                    }

                }
            }
        }
    }
}
