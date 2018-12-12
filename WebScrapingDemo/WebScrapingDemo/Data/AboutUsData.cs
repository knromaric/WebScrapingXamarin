using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WebScrapingDemo.Models;

namespace WebScrapingDemo.Data
{
    public class AboutUsData
    {
        public ObservableCollection<AboutUs> GetAboutUs()
        {
            return new ObservableCollection<AboutUs>
            {
                new AboutUs{ Title="ABOUT US", Description="A small candle that was lit up by Piranis in the small city of Hyderabad on the banks of Great River Indus has been able to spread its shine across the borders to south middle & eastern Asian countries with sustained hardworking and ability to see beyond limits and this all took less than four decades to accomplish what was once a mere dream. Since the birth of first Pirani business entity a vigilant tireless & growth oriented conception towards business by the Father Figure of Piranis enabled the entire organization to move swiftly towards achievement of its goal by ensuring individual participation of everyone concerned. The Ultimate success in the shape of a trusted professional business group by the name of Pirani Group of Companies emerged on the surface of the corporate world."},
                new AboutUs{ Title="VISION", Description="To be a progressive business group that attain success through providing best products to its valued customers in most professional way to achieve satisfaction of its stake holders, Society, Country and international community."},
                new AboutUs{ Title="MISSION", Description="To offer continuous quality for customers at every level to win their trust by providing real value for their money. To offer best working & congenial environment for employees, vendors, dealers & other associates to ensure their confidence to optimum level so that in return they play a positive role in developing a healthy responsible &growing society. To be an organizational entity that responds to every aspect of corporate Governance on moral ethical and legal grounds."},
                new AboutUs{ Title="THE EDGE", Description="Pirani group has never compromised to put up its money for Best Machinery, Best Material & Best Manpower to enable it producing Best quality products to its markets. State of the art well equipped factories and plants being operated by the best available & trained professionals making it through to see the cutting edge in tough competitive markets."},
                new AboutUs{ Title="GROWTH", Description="Immense expansion of the Pirani Group in a very short span of time has not only satisfied its stake holders but also has earned a high value of respect in the eyes of society as well."},
            };
        }
    }
}
