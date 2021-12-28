namespace Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal sealed class Movie : Content, IPlayable, IViewable
    {
        public Movie(string title):base(title)
        {

        }

        public void Play()
        {
            throw new NotImplementedException();
        }

        public void View()
        {
            throw new NotImplementedException();
        }
    }
}
