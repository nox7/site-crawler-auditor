using site_crawler_auditor.WebCrawler;

namespace SiteCrawlerAuditorTests
{
    [TestClass]
    public class UriUtilityTest
    {
        [TestMethod]
        public void TestCompileListOfDirectories()
        {
            string url1 = "https://example.com/some/directory/images/file.png";
            string url2 = "https://example.com/some/directory/images/";
            string url3 = "https://example.com/some/directory/images";

            Uri uri1 = new Uri(url1);
            Uri uri2 = new Uri(url2);
            Uri uri3 = new Uri(url3);

            List<string> directories1 = URIUtility.CompileListOfDirectories(uri1);
            List<string> directories2 = URIUtility.CompileListOfDirectories(uri2);
            List<string> directories3 = URIUtility.CompileListOfDirectories(uri3);

            List<string> expectedDirectories1 = new List<string>
            {
                "some","directory","images"
            };

            List<string> expectedDirectories2 = new List<string>
            {
                "some","directory","images"
            };

            List<string> expectedDirectories3 = new List<string>
            {
                "some","directory"
            };

            CollectionAssert.AreEqual(expectedDirectories1, directories1);
            CollectionAssert.AreEqual(expectedDirectories2, directories2);
            CollectionAssert.AreEqual(expectedDirectories3, directories3);
        }
    }
}