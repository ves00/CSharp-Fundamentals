using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main()
        {
            string inputPassword = Console.ReadLine();
            bool isLengthValid = IsPasswordLenghthVaalid(inputPassword);
            bool isPassAlphanumeric = IsPasswordAlphaNumeric(inputPassword);
            bool isPasswordContainingAtLeastTwoDigits = IsPasswordContainingAtLeastTwoDigits(inputPassword);

            if (!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPassAlphanumeric)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isPasswordContainingAtLeastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isLengthValid && isPassAlphanumeric && isPasswordContainingAtLeastTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsPasswordLenghthVaalid(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }

        static bool IsPasswordAlphaNumeric(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsPasswordContainingAtLeastTwoDigits(string password)
        {
            int digitsCnt = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCnt++;
                }
            }
            return digitsCnt >= 2;
        }
    }
}
