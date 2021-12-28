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

        public void Listen()
        {
            Console.WriteLine("An movie is being listened to.");
        }

        public void Play()
        {
            Console.WriteLine("An movie is being played.");
        }

        public void View()
        {
            Console.WriteLine("An movie is being viewed.");
        }
    }
}
