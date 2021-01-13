using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavPage : ContentPage
    {
        public NavPage()
        {
            InitializeComponent();
        }

        private async void MasterDetailPageNav(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MasterDetailPage());
        }

        private async void TabbedPageNav(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TabbedPage());
        }

        private async void CarouselPageNav(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarouselPage());
        }


    }
}