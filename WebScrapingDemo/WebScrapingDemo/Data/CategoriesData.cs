using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WebScrapingDemo.Models;

namespace WebScrapingDemo.Data
{
    public class CategoriesData
    {
        public ObservableCollection<ProductsCategory> GetCategories()
        {
            return new ObservableCollection<ProductsCategory>()
            {
                new ProductsCategory{CategoryName="Euro-F", CategoryUrl="rt-col-lg-4 rt-col-md-4 rt-col-sm-6 rt-col-xs-12 equal-height isotope-item  euro-f"},
                new ProductsCategory{CategoryName="Power Motorcycle", CategoryUrl="rt-col-lg-4 rt-col-md-4 rt-col-sm-6 rt-col-xs-12 equal-height isotope-item  power-motorcycle"},
                new ProductsCategory{CategoryName="Power Trucs & Vans", CategoryUrl="rt-col-lg-4 rt-col-md-4 rt-col-sm-6 rt-col-xs-12 equal-height isotope-item  power-truck"},
                new ProductsCategory{CategoryName="Super Power", CategoryUrl="rt-col-lg-4 rt-col-md-4 rt-col-sm-6 rt-col-xs-12 equal-height isotope-item  super-power"}
            };
        }
    }
}
