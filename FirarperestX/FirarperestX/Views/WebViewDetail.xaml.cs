using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FirarperestX.Views
{
    public partial class WebViewDetail : ContentPage
    {
        public WebViewDetail()
        {
            InitializeComponent();
            webviewDetail.Source = new Uri((Application.Current as App).selectedPhotoset.Url);
        }
    }
}
