using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WebScrapingDemo.Data;
using WebScrapingDemo.Models;

namespace WebScrapingDemo.ViewModels
{
    public class AboutUsViewModel: BaseViewModel
    {
        private AboutUsData _aboutUsData;
        public ObservableCollection<AboutUs> AboutUsCollection { get; set; }

        public AboutUsViewModel()
        {
            _aboutUsData = new AboutUsData();
            AboutUsCollection = _aboutUsData.GetAboutUs();
        }
    }
}
