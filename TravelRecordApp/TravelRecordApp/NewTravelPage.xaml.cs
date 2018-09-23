using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRecordApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;


namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                Experience = experieceEntry.Text
            };

            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<Post>();
            var rows = conn.Insert(post);
            conn.Close(); // se non chiudo eccezzione...
            if (rows > 0)
            {
                DisplayAlert("Success", "Experience succesfully inserter", "OK");
            }
            else
            {
                DisplayAlert("Failure", "Experience failed to be inserted", "OK");
            }
        }
    }
}