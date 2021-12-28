namespace Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Book : Text, IReadable
    {
        public Book(string title) : base(title)
        {
        }

        public void Read()
        {
            throw new NotImplementedException();
        }
    }
}
