using System;
using System.Collections;
using HtmlAgilityPack;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webscrapingIntro
{
    class Program
    {
        //tutorial http://articles.runtings.co.uk/2009/11/easily-extracting-links-from-snippet-of.html
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            String html = client.DownloadString("https://www.google.com");
            //Console.WriteLine(html);
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            List<string> arr = new List<string>();
            foreach(HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                HtmlAttribute att = link.Attributes["href"];
                Console.WriteLine(att.Value);
                arr.Add(att.Value);
            }


            Console.ReadKey();

        }
    }
}
