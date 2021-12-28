namespace Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Content
    {
        private string _title;

        public Content(string title)
        {
            _title = title;
        }

        public string GetTitle() { return _title; }

        //public void  SetTitle(string title) {  _title = title; }
    }
}
