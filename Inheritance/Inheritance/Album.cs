namespace Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Album : Content, IPlayable, IListenable
    {
        ICollection<Song> _songs;
        public Album(string title) : base(title)
        {
            _songs = new List<Song>();
        }

        public Album(string title, ICollection<Song> songs) : base(title)
        {
            _songs = songs;
        }

        public string Play()
        {
            return("An album is being played.");
        }

        public string Listen()
        {
            return("An album is being listened to.");
        }

        public int SongCount => _songs.Count;
    }
}