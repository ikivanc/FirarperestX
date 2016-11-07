using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FirarperestX.Views
{
    public partial class DetailPage : ContentPage
    {
        public Photoset selectedImage;

        public DetailPage()
        {
            InitializeComponent();

            selectedImage = (Application.Current as App).selectedPhotoset;

            //detailStack.DataContext = selectedImage;
            detailStack.BindingContext = selectedImage;

            //MapIcon mapIcon1 = new MapIcon();

            //BasicGeoposition a = new BasicGeoposition();

            //a.Longitude = selectedImage.Longitude;

            //a.Latitude = selectedImage.Latitude;

            //mapIcon1.Location = new Geopoint(a);

            //mapIcon1.NormalizedAnchorPoint = new Point(0.3, 0.3);

            //mapDetail.Center = new Geopoint(a);

            ////mapIcon1.Title = selectedImage.City;

            //mapIcon1.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/pin.png"));

            //mapIcon1.ZIndex = 0;

            //mapDetail.MapElements.Add(mapIcon1);


           

        }
    }
}
