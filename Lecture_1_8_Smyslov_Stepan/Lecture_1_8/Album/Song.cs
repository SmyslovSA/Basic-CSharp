using System;

namespace Lecture_1_8
{
    public class Song
    {
        private string _name;
        private string _artist;

        public string Name { get { return _name; } set {_name=value; }}
        public string Artist { get { return _artist; } set { _name = value; } }

        public Song() : this("Unknown name", "Unknown artist") { }
        public Song(string name, string artist)
        {
            _name = name;
            _artist = artist;
        }
    }
}
