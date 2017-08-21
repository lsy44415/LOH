using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace aqq
{
    public partial class EnglishPage : CarouselPage
    {
        public EnglishPage()
        {
            InitializeComponent();
        }
		void OnLabel1Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/how-to-self-study-english-online/"));
		}
		void OnLabel2Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/power-writing/"));
		}
		void OnLabel3Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/practise-speaking-english-nursery-rhymes/"));
		}
		void OnLabel4Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/everydayenglish/"));
		}
		void OnLabel5Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/master-idioms/"));
		}
		void OnLabel6Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/5-days-to-a-better-accent/"));
		}
    }
}
