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

        public string Play()
        {
            return("AudioBook is being listend to.");
        }

        public string Read()
        {
            return("AudioBook is being read.");
        }
    }
}
