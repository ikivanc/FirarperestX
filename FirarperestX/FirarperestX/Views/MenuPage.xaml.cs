using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FirarperestX.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();

            Title = "Firarperest";
            listMenu.ItemsSource = new List<String> { "Photos" , "Show by Country", "Show on Map", "Go to Website"};    
        }

        private async void onMenuSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string selectedItem = listMenu.SelectedItem as String;

            if (selectedItem == "Photos")
            {
                await this.Navigation.PushModalAsync(new Views.Home());
            }
            else if (selectedItem == "Show by Country")
            {
                await this.Navigation.PushModalAsync(new Views.PageByCountry());
            }
            else if (selectedItem == "Show on Map")
            {
                await this.Navigation.PushModalAsync(new Views.PageOnMap());
            }
            else if (selectedItem == "Go to Website")
            {            
                Device.OpenUri(new Uri("http://ikivanc.tumblr.com"));            
            }

            listMenu.SelectedItem = null;
        }
    }
}
