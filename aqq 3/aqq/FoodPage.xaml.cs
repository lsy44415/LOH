﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace aqq
{
    public partial class FoodPage : CarouselPage
    {
        public FoodPage()
        {
            InitializeComponent();
        }
		void OnLabel1Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.edx.org/course/science-cooking-haute-cuisine-soft-harvardx-spu27-1x-0"));
		}
		void OnLabel2Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.edx.org/course/sustainable-food-security-food-access-wageningenx-fssfax"));
		}
		void OnLabel3Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/up-beet-cooking-fundamentals/"));
		}
		void OnLabel4Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.edx.org/course/nutrition-health-macronutrients-wageningenx-nutr101x"));
		}
		void OnLabel5Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/simple-and-easy-japanese-fish-recipes-cooked-in-a-microwave/"));
		}
		void OnLabel6Tapped(object sender, EventArgs args)
		{
			Device.OpenUri(new Uri("https://www.udemy.com/faster-than-rice-cooker-microwave-rice-recipes/"));
		}
    }
}
