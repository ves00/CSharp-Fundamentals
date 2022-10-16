﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main()
        {
            List<string> words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];

                if (cmdType == "merge")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    FixInvalidIndexes(words, ref startIndex, ref endIndex);
                    MergetWords(words, startIndex, endIndex);


                }
                else if (cmdType == "divide")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int partitions = int.Parse(cmdArgs[2]);
                    //abcde -> ab, bc, e (Wrong, we want the last one to be the longest)
                    //abcde -> a, b, cde 5 : 3 = 1 
                    //abcdef -> ab, cd, ef
                    string word = words[index];
                    List<string> partitionsList = DivideWord(word, partitions);

                    words.RemoveAt(index);
                    words.InsertRange(index, partitionsList);

                }
            }
            Console.WriteLine(string.Join(" ", words));
        }
        static void FixInvalidIndexes(List<string> words, ref int startIndex, ref int endIndex)
        {
            if (startIndex < 0)
            {
                //First possible
                startIndex = 0;
            }
            if (startIndex >= words.Count)
            {
                startIndex = words.Count - 1;
            }
            if (endIndex <= 0)
            {
                endIndex = 0;
            }
            if (endIndex >= words.Count)
            {
                //Last possible
                endIndex = words.Count - 1;
            }
        }

        static void MergetWords(List<string> words, int startIndex, int endIndex)
        {
            string mergedText = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                string currWord = words[startIndex];
                mergedText += currWord;
                words.RemoveAt(startIndex);
            }
            words.Insert(startIndex, mergedText);
        }

        static List<string> DivideWord(string word, int partitions)
        {
            int substringLength = word.Length / partitions;
            int lastSubstringLength = word.Length - ((partitions - 1) * substringLength);

            List<string> partitionsList = new List<string>();
            //All without the last one
            for (int i = 0; i < partitions; i++)
            {
                int desiredLenght = substringLength;
                if (i == partitions - 1)
                {
                    desiredLenght = lastSubstringLength;
                }
                char[] newParitonArr = word
                    .Skip(i * substringLength)
                    .Take(desiredLenght)
                    .ToArray();
                string newPartition = String.Join("", newParitonArr);
                partitionsList.Add(newPartition);
            }
            return partitionsList;
        }
    }
}
