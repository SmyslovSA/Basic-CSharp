using System;
using System.Collections.Generic;

namespace Lecture_1_8.AlbumClasses
{
    public class Album
    {
        private readonly List<Song> _album;

        public Album()
        {
            _album = new List<Song>();
        }

        public Album(List<Song> list)
        {
            _album = list;
        }

        public Song this[int i]
        {
            get { return IndexIsInRange(i) ? _album[i] : null; }
            set
            {
                if (!IndexIsInRange(i) || value == null) return;
                _album[i] = value;
            }
        }

        public bool IndexIsInRange(int index)
        {
            return index >= 0 && index < _album.Count;
        }

        public void AddSong(Song song)
        {
            if (song != null) _album.Add(song);
        }

        public void SetTestAlbum(Album album)
        {
            var newSong = new Song();
            var newSong2 = new Song();
            var newSong3 = new Song();
            var newSong4 = new Song();
            var newSong5 = new Song();
            album.AddSong(newSong);
            album.AddSong(newSong2);
            album.AddSong(newSong3);
            album.AddSong(newSong4);
            album.AddSong(newSong5);
        }
    }
}