using Mobile_HW3.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Mobile_HW3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UniversityDetails : ContentPage
    {
        public UniversityDetails(string logo, string name, string type, string location, string url)
        {
            InitializeComponent();
            var vm = new UniversityDetailsViewModel();
            vm.Logo = logo;
            vm.Name = name;
            vm.Type = type;
            vm.Location = location;
            vm.Url = url;
            this.BindingContext = vm;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            try
            {
                await Browser.OpenAsync(uni_url.Text, BrowserLaunchMode.SystemPreferred);
            }
            catch
            {
                Console.WriteLine(uni_url.Text);
                string eksik_url = "http://" + uni_url.Text;
                try
                {
                    await Browser.OpenAsync(eksik_url, BrowserLaunchMode.SystemPreferred);
                }
                catch
                {
                    Console.WriteLine("Error");
                }
                

            }

        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            var placemark = new Placemark
            {
                CountryName = "Turkey",
                AdminArea = "",
                Thoroughfare = uni_name.Text,
                Locality = uni_city.Text
            };
            await Map.OpenAsync(placemark, new MapLaunchOptions
            {
                Name = uni_name.Text,
                NavigationMode = NavigationMode.None
            }) ;
        }
    }
}