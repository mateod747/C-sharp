using ScrapeLibrary;
using System;

namespace PrintURL
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();

            string value = myScrape.ScrapeWebPage("https://www.youtube.com/");

            Console.WriteLine(value);
        }
    }
}
