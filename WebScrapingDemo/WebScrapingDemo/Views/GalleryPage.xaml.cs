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
	public partial class GalleryPage : ContentPage
	{
        private GalleryViewModel _galleryViewModel;
		public GalleryPage ()
		{
			InitializeComponent ();
            _galleryViewModel = new GalleryViewModel();
            BindingContext = _galleryViewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await _galleryViewModel.SetData();
        }
    }
}