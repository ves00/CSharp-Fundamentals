using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main()
        {
            //["string", new List<string> {"str1", "str2"}]
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            // synonyms.Add("cute", new List<string>());
            // synonyms["cute"].Add("charming");
            //List.Add("charming");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonyms.ContainsKey(word))
                {
                    List<string> newListForCurrentWord = new List<string>();
                    synonyms.Add(word, new);
                }

                synonyms[word].Add(synonym);
            }

            foreach (var item in synonyms)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
