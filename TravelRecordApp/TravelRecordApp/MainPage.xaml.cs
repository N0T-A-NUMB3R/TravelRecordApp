using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void LoginButton_OnClicked(object sender, EventArgs e)
        {
            var isEmptyEmail = string.IsNullOrEmpty(emailEntry.Text);
            var isPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);
            if (isEmptyEmail || isPasswordEmpty)
            {

            }
            else
            {
                Navigation.PushAsync(new HomePage()); // manda una nuova pagina sullo schermo
            }

        }
    }
}
