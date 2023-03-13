using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            string uriPath = pageUri.AbsolutePath;

            List<string> directories = uriPath.Split("/").ToList();

            // Remove the first and last list items.
            // The first item is just when "/" is split (blank) and the last item should never be considered
            // As it is either a blank "/" or a file name/accessor.
            directories.RemoveAt(0);
            directories.RemoveAt(directories.Count - 1);

            return directories;
        }
    }
}
