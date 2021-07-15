using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp.Model
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public event PropertyChangedEventHandler propertChanged;
        public ICommand BaseCommand => new Command(CommandClicked);
        public login()
        {
            InitializeComponent();
            BindingContext = this;
        }

        // Login System for logging in 

        public async void CommandClicked()
        {
            if (userTxt.Text == "Admin" && pswdTxt.Text == "12345")
            {
                await Navigation.PushAsync(new CurrentWeatherPage());
            }
            else
            {
                await DisplayAlert("Login Error", "Invalid Username / Password", "OK");
            }
        }
    }
}