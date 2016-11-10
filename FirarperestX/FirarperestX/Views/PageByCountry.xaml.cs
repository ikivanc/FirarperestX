using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FirarperestX.Views
{
    public partial class PageByCountry : ContentPage
    {
        public PageByCountry()
        {
            InitializeComponent();

            Photoset ps = new Photoset();
            listviewPhotos.ItemsSource = ps.getByCountryGrouped();

        }


        public async void onTapped(object sender, ItemTappedEventArgs e)
        {
            var list = (ListView)sender;
            var selectedphoto = e.Item as Photoset;

            (Application.Current as App).selectedPhotoset = selectedphoto;

            await this.Navigation.PushModalAsync(new Views.DetailPage());

            list.SelectedItem = null;
        }
    }
}
