using System;
using System.IO;
using System.Net;

namespace ScrapeLibrary
{
    public class Scrape
    {
        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }

        public string ScrapeWebPage(string url)
        {
            string value = GetWebPage(url);
            value += "HEHEHEHE";
            return value;
        }

        public string ScrapeWebPage(string url, string filepath)
        {
            string value = GetWebPage(url);
            value += "HEHEHEEHE";

            File.WriteAllText(filepath, value);
            return value;
        }
    }
}
