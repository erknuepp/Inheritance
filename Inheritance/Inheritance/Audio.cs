namespace Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Audio : Content, IPlayable
    {
        public Audio(string title) : base(title)
        {

        }

        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
