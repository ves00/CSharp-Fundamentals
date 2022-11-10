using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AssociativeArrays_Exercise
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, string> phoneBook =
                new Dictionary<string, string>();

            string name = Console.ReadLine();

            //Adding entry to dictionary
            //Keys must be unique!
            //1st way
            phoneBook.Add("Pesho", "0889988998");
            //Add new entry if it does not  exist
            //Rewrite existing entry
            phoneBook["Gosho"] = "0878877887";

            // phoneBook.Add("Gosho", "999"); //Error
            phoneBook["Pesho"] = "999";
            //Cheking if the key exists
            if (phoneBook.ContainsKey(name))
            {
                //Getting value by key
                Console.WriteLine(phoneBook[name]);
            }
            else
            {
                Console.WriteLine($"{name} does not exist in your phonebook");
            }

            //Cheking if the value exists(rarely used)
            if (phoneBook.ContainsValue("999"))
            {

            }

            //Dictionary<string , string> => List<KeyValuePair<string, string>>
            //Always when we try to print dictionary or use LINQ on dictionary
            //We neeed to think of the dictionary like List<KeyValuePair>
            foreach (KeyValuePair<string, string> entry in phoneBook)
            {
                Console.WriteLine("Name:    Number:");
                Console.WriteLine($"{entry.Key}        {entry.Value}");
            }

            //Change a value of a key
            string oldName = Console.ReadLine();
            string newName = Console.ReadLine();

            string value = phoneBook[oldName];
            phoneBook.Remove(oldName);
            phoneBook[newName] = value;

            Dictionary<string, string> orderedPhoneBook = phoneBook
                .OrderBy(kvp => kvp.Key)
                .ToDictionary(a => a.Key, b => b.Value);
            foreach (var kvp in orderedPhoneBook)
            {
                Console.WriteLine("Name:    Number:");
                Console.WriteLine($"{kvp.Key}        {kvp.Value}");
            }





        }
    }
}
