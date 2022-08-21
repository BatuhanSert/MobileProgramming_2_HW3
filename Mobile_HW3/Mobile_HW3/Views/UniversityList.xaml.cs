using Mobile_HW3.Models;
using Mobile_HW3.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile_HW3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UniversityList : ContentPage
    {
        public UniversityList()
        {
            InitializeComponent();
            BindingContext = new UniversityViewModel();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var details = e.SelectedItem as Universities;
            await Navigation.PushAsync(new UniversityDetails(
                details.university_logo,
                details.university_name,
                details.university_type,
                details.university_location,
                details.university_url));
        }
    }
}