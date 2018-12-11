using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WebScrapingDemo.Data;
using WebScrapingDemo.Models;
using WebScrapingDemo.Views;
using Xamarin.Forms;

namespace WebScrapingDemo.ViewModels
{
    public class ProductsCategoryViewModel:BaseViewModel
    {
        public ObservableCollection<ProductsCategory> CategoriesCollection { get; set; }
        private CategoriesData _categoriesData;
        private INavigation _navigation;

        private ProductsCategory _categorySelected;

        public ProductsCategory CategorySelected
        {
            get { return _categorySelected; }
            set
            {
                _categorySelected = value;
                if(_categorySelected != null)
                {
                    _navigation.PushAsync(new ProductsPage(_categorySelected));
                }
            }

        }

        public ProductsCategoryViewModel(INavigation navigation)
        {
            _categoriesData = new CategoriesData();
            CategoriesCollection =  _categoriesData.GetCategories();
            _navigation = navigation;
        }
    }
}
