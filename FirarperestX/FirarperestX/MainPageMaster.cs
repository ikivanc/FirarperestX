using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirarperestX
{
    public class MainPageMaster : MasterDetailPage

    {
        //MainPageMaster masterPage;

        public MainPageMaster()
        {
            //masterPage = new MainPageMaster();
            Master = new Views.MenuPage();
            Detail = new Views.Home();
        }
    }
}
