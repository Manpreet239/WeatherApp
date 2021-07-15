using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherApp.Model
{
   public class WeatherDetails
    {
        public string Title
        {
            get;
            set;
        }
        public string Temperature
        {
            get;
            set;
        }
        public string Wind
        {
            get;
            set;
        }
        public string Humidity
        {
            get;
            set;
        }
        public string Visibility
        {
            get;
            set;
        }
        public string Sunrise
        {
            get;
            set;
        }
        public string Sunset
        {
            get;
            set;
        }
        public WeatherDetails()
        {
            this.Title = " ";
            this.Temperature = " ";
            this.Wind = " ";
            this.Humidity = " ";
            this.Visibility = " ";
            this.Sunrise = " ";
            this.Sunset = " ";
        }


    }
}