using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace site_crawler_auditor.WebCrawler
{
    class CrawledPage
    {
        private static HtmlParser HtmlParser = new HtmlParser();

        private Uri URI;
        private string Html;
        private List<Uri> UrisOnPage = new();
        private IDocument? Document;

        public CrawledPage(Uri uri, string html)
        {
            URI = uri;
            this.Html = html;
        }

        public void ParseHTMLDocument()
        {
            this.Document = CrawledPage.HtmlParser.ParseDocument(this.Html);
        }

        /**
         * Iterates through all anchor elements <a> in the HTML document. Adds them to a list of
         * strings and returns that list. This list must be processed to handle any relative URLs. Do not
         * directly rely on the return value of this method to have a clean and usable list of full URLs.
         */
        public List<string> CompileListOfHrefsOnPage()
        {
            List<string> anchorHrefs = new();
            IEnumerable<IHtmlAnchorElement> anchorElements = this.Document.QuerySelectorAll<IHtmlAnchorElement>("a");
            foreach (IElement element in anchorElements)
            {
                string href = element.GetAttribute("href") ?? string.Empty;
                anchorHrefs.Add(href);
            }

            return anchorHrefs;
        }

        /**
         * Processes a list of anchor hrefs from CompileListOfHrefsOnPage. Relative hrefs will become absolute links
         * and all will be processed into Uri objects.
         */
        public List<Uri> ProcessUnsafeListOfHrefsToUris(List<string> listOfHrefs)
        {
            List<Uri> uris = new();
            foreach (string href in listOfHrefs)
            {
                if (href.StartsWith("/"))
                {
                    // Relative URL
                }
                else if (href.StartsWith("http://") || href.StartsWith("https://"))
                {
                    // Absolute URL
                }
                else if (href.StartsWith("tel:") || href.StartsWith("sms://") || href.StartsWith("mailto:"))
                {
                    // TODO, adjust this condition to more of "If starts with a protocol that is not Http protocol" with external method
                }
                else
                {
                    // Relative URL but doesn't start from web root. Must parse the directory of the current page
                    // and use it to determine the full URL of this HREF
                }
            }

            return uris;
        }

    }
}
