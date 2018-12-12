using System;
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
	public partial class NewsAndEventsPage : ContentPage
	{
        private NewsAndEventsViewModel _newsAndEventsViewModel;
        public NewsAndEventsPage ()
		{
			InitializeComponent ();
            _newsAndEventsViewModel = new NewsAndEventsViewModel();
            BindingContext = _newsAndEventsViewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await _newsAndEventsViewModel.SetData();
        }
    }
}