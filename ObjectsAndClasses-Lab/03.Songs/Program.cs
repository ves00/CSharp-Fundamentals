using System;
using System.Collections.Generic;

namespace _03.Songs
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); //3

            List<Song> songs = new List<Song>();
            //{ Song("", name, 1), Song("", name, 1), Song("", name, 1),

            for (int i = 0; i < n; i++)
            {
                string[] currentInput = Console.ReadLine()
                    .Split("_");//favorite_DownTown_3:14

                string typeList = currentInput[0];
                string name = currentInput[1];
                string time = currentInput[2];

                Song song = new Song(typeList, name, time);
                songs.Add(song);
            }
            string list = Console.ReadLine(); //all

            for (int i = 0; i < songs.Count; i++)
            {
                Song currentSong = songs[i];

                if (list == "all")
                {
                    Console.WriteLine(currentSong.Name);
                }
                else if (list == currentSong.TypeList)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }

            // string list = Console.ReadLine();   
        }
    }

    public class Song
    {
        //Constructor
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        //Properties 
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
