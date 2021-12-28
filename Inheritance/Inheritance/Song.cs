namespace Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal sealed class Song : Content, IPlayable, IListenable
    {
        private TimeSpan playTime;
        public Song(string title):base(title)
        {
            playTime = new TimeSpan();
        }

        public Song(string title, TimeSpan playTime) : base(title)
        {
            this.playTime = playTime;
        }

        public void Play()
        {
            Console.WriteLine("A song is being played.");
        }

        public void Listen()
        {
            Console.WriteLine("A song is being listened to.");
        }

        public TimeSpan PlayTime => playTime;
    }
}
