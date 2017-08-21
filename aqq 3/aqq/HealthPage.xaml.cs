﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace aqq
{
    public partial class HealthPage : CarouselPage
    {
        public HealthPage()
        {
            InitializeComponent();
        }
		void OnLabel1Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/osha-safety-pro-personal-protective-equipment/"));
		}
		void OnLabel2Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/emergency-life-support/"));
		}
		void OnLabel3Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/sports-nutrition-crash-course-get-started-with-basics/"));
		}
		void OnLabel4Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/low-fodmap-diet/"));
		}
		void OnLabel5Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.edx.org/course/healthy-ageing-6-steps-let-environment-delftx-eit001x-0"));
		}
		void OnLabel6Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.edx.org/course/life-diabetes-curtinx-diab1x"));
		}
    }
}
