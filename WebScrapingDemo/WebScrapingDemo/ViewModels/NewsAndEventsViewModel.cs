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
    public class NewsAndEventsViewModel: BaseViewModel
    {
        public ObservableCollection<NewsAndEvents> NewsAndEventsCollection { get; set; }

        public NewsAndEventsViewModel()
        {
            NewsAndEventsCollection = new ObservableCollection<NewsAndEvents>();
        }

        public async Task SetData()
        {
            HttpClient httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(@"http://piranigroup.com.pk/news-events/");
            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var nodes = htmlDocument.DocumentNode
                                    .Descendants("div")
                                    .Where(n => n.GetAttributeValue("class", "").Equals("rbs-img-image  rbs-lightbox"));

            foreach (var node in nodes)
            {
                var newsAndEvent = new NewsAndEvents
                {
                    ThumbNail = node.Descendants("div").FirstOrDefault()?.ChildAttributes("data-thumbnail").FirstOrDefault()?.Value
                };

                NewsAndEventsCollection.Add(newsAndEvent);
            }
        }
    }
}
