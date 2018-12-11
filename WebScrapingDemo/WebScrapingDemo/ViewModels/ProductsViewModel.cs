using HtmlAgilityPack;
using MvvmHelpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebScrapingDemo.Models;

namespace WebScrapingDemo.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        public ObservableCollection<Product> ProductsCollection { get; set; }

        public ProductsViewModel()
        {
            ProductsCollection = new ObservableCollection<Product>();
        }

        public async Task SetData(ProductsCategory category)
        {
            HttpClient httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(@"http://piranigroup.com.pk/product-2/");
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var nodes = htmlDocument.DocumentNode.Descendants("div")
                .Where(x => x.GetAttributeValue("class", "").Equals(category.CategoryUrl));

            foreach(var htmlNode in nodes)
            {
                var product = new Product
                {
                    ProductName = HtmlEntity.DeEntitize(htmlNode.Descendants("h2").FirstOrDefault()?.InnerText),
                    ProductImage = HtmlEntity.DeEntitize(htmlNode.Descendants("img").FirstOrDefault()?
                                                     .ChildAttributes("src")
                                                     .FirstOrDefault()?
                                                     .Value)
                };

                ProductsCollection.Add(product);

            }

            
        }
    }
}
