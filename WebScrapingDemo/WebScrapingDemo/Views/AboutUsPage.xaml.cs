﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebScrapingDemo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebScrapingDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutUsPage : ContentPage
	{
		public AboutUsPage ()
		{
			InitializeComponent ();
            BindingContext = new AboutUsViewModel();
		}
	}
}