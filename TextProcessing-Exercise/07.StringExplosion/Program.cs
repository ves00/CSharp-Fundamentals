using System;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main()
        {
            // step 1 reading the input
            string textField = Console.ReadLine();

            //step 2 => create variable for the bomb
            int bomb = 0;
            // step 3 => loop through the textField searching for bomb
            for (int i = 0; i < textField.Length; i++)
            {
                //step 4 checking if the bomb with bigger damage than 0 in the textField and is different from >
                if (bomb > 0 && textField[i] != '>')
                {
                    textField = textField.Remove(i, 1);
                    bomb--;
                    i--;
                }

                //Step 4.1 if the index of the current char == > then we have an explosion and then we add the power of the explosion that we have found on the index and add it to the bomb
                else if (textField[i] == '>')
                {
                    bomb += int.Parse(textField[i + 1].ToString());
                }
            }
            Console.WriteLine(textField);

        }
    }
}
