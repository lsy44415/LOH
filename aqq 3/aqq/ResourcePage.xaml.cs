using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace aqq
{
    public partial class ResourcePage : CarouselPage
    {

        public ResourcePage()
        {
            InitializeComponent();
        }
        void OnLabel1Tapped(object sender, EventArgs args) { 
        Device.OpenUri(new Uri("https://www.udemy.com/how-to-make-a-wordpress-website-2017-divi-theme-tutorial/"));
    }
		void OnLabel2Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/html5-video-player/"));
		}
		void OnLabel3Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/quickstart-angularjs/"));
		}
		void OnLabel4Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/build-your-first-website-in-1-week/"));
		}
		void OnLabel5Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/aws-step-functions/"));
		}
		void OnLabel6Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.coursera.org/learn/how-to-create-a-website"));
		}
    }
}
