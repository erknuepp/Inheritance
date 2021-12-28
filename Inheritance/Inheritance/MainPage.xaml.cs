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
        ContentLibrary contentLibrary;
        public MainPage()
        {
            InitializeComponent();
            contentLibrary = new ContentLibrary();

            var contentTypes = new List<string>();
            contentTypes.Add("Book");
            contentTypes.Add("AudioBook");
            contentTypes.Add("Movie");
            contentTypes.Add("Album");
            contentTypes.Add("Song");

            contentTypePicker.ItemsSource = contentTypes;


        }

        public void addContentButtonClicked(object sender, EventArgs e)
        {
            var contentType = contentTypePicker.SelectedItem as string;
            var title = contentTitle.Text;

            switch (contentType)
            {
                case ("Book"):
                    contentLibrary.Add(new Book(title));
                    break;
                case ("AudioBook"):
                    contentLibrary.Add(new AudioBook(title));
                    break;
                case ("Movie"):
                    contentLibrary.Add(new Movie(title));
                    break;
                case ("Album"):
                    contentLibrary.Add(new Album(title));
                    break;
                case ("Song"):
                    contentLibrary.Add(new Song(title));
                    break;
                default:
                    break;
            }
            contentTypePicker.SelectedIndex = -1;
            contentTitle.Text = "";
            contentLibraryListView.ItemsSource = contentLibrary.Contents;
        }

        public void playButtonClicked(object sender, EventArgs e)
        {
            var selectedContentItem = contentLibraryListView.SelectedItem;
            if (selectedContentItem != null)
            {
                if(selectedContentItem is Movie)
                {
                    stateMessage.Text = ((Movie)selectedContentItem).Play();
                }
            }
        }

        public void viewButtonClicked(object sender, EventArgs e)
        {

        }
    }
}
