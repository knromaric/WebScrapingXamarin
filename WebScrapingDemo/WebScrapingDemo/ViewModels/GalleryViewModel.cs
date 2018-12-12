using HtmlAgilityPack;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebScrapingDemo.Models;

namespace WebScrapingDemo.ViewModels
{
    public class GalleryViewModel: BaseViewModel
    {
        public ObservableCollection<Gallery> GalleryCollection { get; set; }

        public  GalleryViewModel()
        {
            GalleryCollection = new ObservableCollection<Gallery>();
            //SetData();
        }

        public async Task SetData()
        {
            HttpClient httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(@"http://piranigroup.com.pk/gallery/");
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var nodes = htmlDocument.DocumentNode
                                    .Descendants("div")
                                    .Where(n => n.GetAttributeValue("Class", "").Equals("rbs-img-image  rbs-lightbox"))
                                    .ToList();
                          

            foreach (var node in nodes)
            {
                var gallery = new Gallery()
                {
                    ThumbNail = node.Descendants("div")
                                    .FirstOrDefault()?
                                    .ChildAttributes("data-thumbnail")
                                    .FirstOrDefault()?
                                    .Value
                };

                GalleryCollection.Add(gallery);
            }
        }

    }
}
