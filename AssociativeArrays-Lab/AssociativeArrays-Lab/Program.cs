using System;
using System.Collections.Generic;

namespace AssociativeArrays_Lab
{
    internal class Program
    {
        static void Main()
        {
            //Demo 01
            /*
             SortedDictionary<string, string> phoneNumbers = new SortedDictionary<string, string>();


             phoneNumbers["Veselin Veselinov2"] = "-07da - 12785";
             phoneNumbers["Veselin Veselinov3"] = "-074da - 12785";
             phoneNumbers["Veselin Veselino4v"] = "-074da - 12785";

             foreach (var phoneNumber in phoneNumbers)
             {
                 Console.WriteLine(phoneNumber);
             }

             */






            //Demo 02 Add(key, value)

            /*
            Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();


            //phoneNumbers["Veselin Veselinov2"] = "-07da - 12785";
            // phoneNumbers["Veselin 3"] = "-074da - 12785";

            phoneNumbers.Add("Veselin Veselinov", "7870987097");


            foreach (var phoneNumber in phoneNumbers)
            {
                Console.WriteLine(phoneNumber);
            }
            */





            //Demo 03 Remove(key)
            /*
            Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();


            //phoneNumbers["Veselin Veselinov2"] = "-07da - 12785";
            // phoneNumbers["Veselin 3"] = "-074da - 12785";

            phoneNumbers.Add("Veselin Veselinov", "7870987097");

            phoneNumbers.Remove("Veselin Veselinov");

            phoneNumbers.Add("Veselin Veselinov", "7-8-8-8-8-8");


            foreach (var phoneNumber in phoneNumbers)
            {
                Console.WriteLine(phoneNumber);
            }
            */







            //Demo 04 ContainsKey(key)
            /*
            Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

            //phoneNumbers["Veselin Veselinov2"] = "-07da - 12785";
            // phoneNumbers["Veselin 3"] = "-074da - 12785";
            if (!phoneNumbers.ContainsKey("Veselin Veselinov"))
            {
                phoneNumbers.Add("Veselin Veselinov", "7-8-8-8-8-8");
            }

            if (!phoneNumbers.ContainsKey("Veselin Veselinov"))
            {
                phoneNumbers.Add("Veselin Veselinov", "7-8-8-8-8-8");
            }

            foreach (var phoneNumber in phoneNumbers)
            {
                Console.WriteLine(phoneNumber);
            }
            */





            //Demo 05 ContainsValue(value)
            /*
            Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

            //phoneNumbers["Veselin Veselinov2"] = "-07da - 12785";
            // phoneNumbers["Veselin 3"] = "-074da - 12785";
            if (!phoneNumbers.ContainsKey("Veselin Veselinov"))
            {
                phoneNumbers.Add("Veselin Veselinov", "7-8-8-8-8-8");
            }

            Console.WriteLine(phoneNumbers.ContainsValue("7-8-8-8-8-8"));

            foreach (var phoneNumber in phoneNumbers)
            {
                Console.WriteLine(phoneNumber);
            }
            */



            //Demo 06 
            /*
            Dictionary<int, int> phoneNumbers = new Dictionary<int, int>();

            for (int i = 1; i <= 100; i++)
            {
                phoneNumbers.Add(i, i + 1);
            }

            Console.WriteLine(phoneNumbers[50]);
            */



            //Demo 07 Printing ivan's age
            /*
            Dictionary<string, int> phoneNumbers = new Dictionary<string, int>();

            phoneNumbers.Add("Veselin", 286);
            phoneNumbers.Add("Petkan", 20);
            phoneNumbers.Add("Ivan", 22);
            phoneNumbers.Add("Jon", 27);
            phoneNumbers.Add("Stella", 29);

            Console.WriteLine(phoneNumbers["Ivan"]);
            */




            //Demo 08 All in one
            /*
            Dictionary<string, int> phoneNumbers = new Dictionary<string, int>();

            phoneNumbers.Add("Veselin Veselinov", 626);

            if (!phoneNumbers.ContainsKey("12"))
            {
                Console.WriteLine(phoneNumbers["12"]);
            }

            phoneNumbers.Remove("Veselin Veselinov");

            foreach (var item in phoneNumbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            */



            //Demo 09 Dictionary<string, Dictionary<string, string> synonyms = new Dictionary<string, Dictionary<string, string>>();
            /*
            Dictionary<string, Dictionary<string, string>> synonyms = new Dictionary<string, Dictionary<string, string>>();

            var dictForWord = new Dictionary<string, string>();
            synonyms.Add("cute", dictForWord);

            synonyms["cute"].Add("something", "else");

            foreach (var item in synonyms)
            {
                Console.WriteLine(item.Key);
                foreach (var val in item.Value)
                {
                    Console.WriteLine($"{val.Key}: {val.Value}");
                }
            }
            */
        }
    }
}
