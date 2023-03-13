using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace site_crawler_auditor.WebCrawler
{
    public static class URIUtility
    {
        /**
         * Takes an absolute URI and returns an ordered list of directories from the URI. This will assume that the URI provided
         * is the URI of the subject page - this is important because if the final character in the last directory path is not
         * a /, then the last value of the returning List is chopped off.
         * 
         * E.g. https://example.com/some/directory/images/file.png will return a list containing "some" "directory" "images"
         * E.g. https://example.com/some/directory/images/ will return a list containing "some" "directory" "images",
         * E.g. https://example.com/some/directory/images will return a list containing "some" "directory"
         */
        public static List<string> CompileListOfDirectories(Uri pageUri)
        {
            string uriAsString = pageUri.ToString();
            Regex domainRegex = new Regex(@"^https?:\/\/([^\/]+)\/?");
            Match domainMatch = domainRegex.Match(uriAsString);
            string protocolWithDomain = domainMatch.Value;

            // Remove the protocol and host from the uri, leaving just the path
            string relativeUriAsString = uriAsString.Replace(protocolWithDomain, string.Empty);
            List<string> directories = relativeUriAsString.Split("/").ToList();
            directories.RemoveAt(directories.Count - 1);

            return directories;
        }
    }
}
