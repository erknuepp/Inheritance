namespace Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var contentTypes = new List<string>();
            contentTypes.Add("Book");
            contentTypes.Add("AudioBook");
            contentTypes.Add("Movie");
            contentTypes.Add("Song");

            contentTypePicker.ItemsSource = contentTypes;
        }

        public void AddContentButtonClicked()
        {

        }
    }
}
