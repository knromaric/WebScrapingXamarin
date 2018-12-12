using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using WebScrapingDemo.Views;
using Xamarin.Forms;

namespace WebScrapingDemo.ViewModels
{
    public class HomePageViewModel: BaseViewModel
    {
        public Command AboutUsCommand { get;}
        public Command ContactUsCommand { get;}
        public Command ProductsCommand { get;}
        public Command GalleryCommand { get;}
        public Command NewsAndEventsCommand { get;}
        public Command LikePageCommand { get;}

        private INavigation _navigation; 

        public HomePageViewModel(INavigation navigation)
        {
            AboutUsCommand = new Command(AboutCommandMethod);
            ContactUsCommand = new Command(ContactCommandMethod);
            ProductsCommand = new Command(ProductsCommandMethod);
            GalleryCommand = new Command(GalleryCommandMethod);
            NewsAndEventsCommand = new Command(NewsAndEventsCommandMethod);
            LikePageCommand = new Command(LikePageCommandMethod);

            _navigation = navigation;
        }

        private void LikePageCommandMethod(object obj)
        {
            Device.OpenUri(new Uri("https://www.facebook.com"));
        }

        private void NewsAndEventsCommandMethod(object obj)
        {
            _navigation.PushAsync(new NewsAndEventsPage());
        }

        private void GalleryCommandMethod(object obj)
        {
            _navigation.PushAsync(new GalleryPage());
        }

        private void ProductsCommandMethod(object obj)
        {
            _navigation.PushAsync(new ProductsCategoryPage());
        }

        private void ContactCommandMethod(object obj)
        {
            _navigation.PushAsync(new ContactUsPage());
        }

        private void AboutCommandMethod(object obj)
        {
            _navigation.PushAsync(new AboutUsPage());
        }
    }
}
