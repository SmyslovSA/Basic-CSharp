using System;

namespace Lecture_1_8.AlbumClasses
{
    public class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }       

        public Song() : this("Unknown name", "Unknown artist")
        {
        }

        public Song(string name, string artist)
        {
            Name = name;
            Artist = artist;
        }
    }
}