namespace Inheritance
{
    using System.Collections.Generic;

    internal sealed class ContentLibrary
    {
        ICollection<Content> contents;

        public ContentLibrary()
        {
            contents = new List<Content>();
        }

        public void Add(Content content)
        {
            contents.Add(content);
        }

        public ICollection<Content> Contents => contents; 
    }
}