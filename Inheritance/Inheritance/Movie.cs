namespace Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal sealed class Movie : Video, IPlayable, IViewable, IListenable
    {
        public Movie(string title):base(title)
        {

        }

        public string Listen()
        {
            return("An movie is being listened to.");
        }

        public string Play()
        {
            return("An movie is being played.");
        }

        public string View()
        {
            return("An movie is being viewed.");
        }
    }
}
