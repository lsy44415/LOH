﻿﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace aqq
{
    public partial class HomePage : TabbedPage
    {
        public HomePage()
        {
            InitializeComponent();
           
        }

		async void OnImage1Tapped(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new MyPage());
		}
		async void OnImage2Tapped(object sender, EventArgs args)
		{
            await DisplayAlert("Sorry", "This function does not work right now", "OK");
			//await Navigation.PushAsync(new MyPage());
		}
		async void OnImage3Tapped(object sender, EventArgs args)
		{
			await DisplayAlert("Sorry", "This function does not work right now", "OK");
            //await Navigation.PushAsync(new MyPage());
		}
		async void OnImage4Tapped(object sender, EventArgs args)
		{
			await DisplayAlert("Sorry", "This function does not work right now", "OK");
            //await Navigation.PushAsync(new MyPage());


		}
    }
}
