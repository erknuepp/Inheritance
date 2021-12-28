namespace Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class AudioBook : Content, IPlayable, IReadable
    {
        public AudioBook(string title): base(title)
        {

        }

        public void Play()
        {
            Console.WriteLine("AudioBook is being listend to.");
        }

        public void Read()
        {
            Console.WriteLine("AudioBook is being read.");
        }
    }
}
