using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace site_crawler_auditor.WebCrawler
{
    class WebCrawler
    {

        private Uri baseUri;
        private HttpClient httpClient;

        public WebCrawler(Uri baseUri)
        { 
            this.baseUri = baseUri;
            HttpClientHandler httpClientHandler = new HttpClientHandler()
            {
                AutomaticDecompression = System.Net.DecompressionMethods.All
            };

            this.httpClient = new HttpClient(httpClientHandler)
            {
                BaseAddress = baseUri
            };
        }

        /**
         * 
         */
        public async Task<CrawlResult> CrawlSite()
        {

        }

        public async Task<CrawledPage> CrawlPage(Uri pageUri)
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, pageUri);
            using HttpResponseMessage response = await this.httpClient.SendAsync(request);

        }
        
    }
}
