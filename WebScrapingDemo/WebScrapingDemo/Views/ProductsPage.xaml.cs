using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebScrapingDemo.Models;
using WebScrapingDemo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebScrapingDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductsPage : ContentPage
	{
        private ProductsViewModel _productsViewModel;
        private ProductsCategory _categorySelected;
        public ProductsPage (ProductsCategory categorySelected)
		{
			InitializeComponent ();
            _categorySelected = categorySelected;
            _productsViewModel = new ProductsViewModel();
            BindingContext = _productsViewModel;  
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
           await _productsViewModel.SetData(_categorySelected);
        }


    }
}