using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview.Misc
{
    /// <summary>
    /// this code-snippet was copy from http://www.sharejs.com/codes/csharp/
    /// </summary>
    class DomainRetriever
    {
        /// <summary>
        /// using the build-in Uri-object
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static string ExtractDomainNameFromURL_Method1(string Url)
        {
            if (!Url.Contains("://"))
                Url = "http://" + Url;

            return new Uri(Url).Host;
        }

        /// <summary>
        /// using string modifiers
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static string ExtractDomainNameFromURL_Method2(string Url)
        {
            if (Url.Contains(@"://"))
                Url = Url.Split(new string[] { "://" }, 2, StringSplitOptions.None)[1];

            return Url.Split('/')[0];
        }

        /// <summary>
        /// using regular expressions -> slowest
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>
        public static string ExtractDomainNameFromURL_Method3(string Url)
        {
            return System.Text.RegularExpressions.Regex.Replace(
                Url,
                @"^([a-zA-Z]+:\/\/)?([^\/]+)\/.*?$",
                "$2"
            );
        }


        //private static void Main(string[] args)
        //{
        //    string[] Urls = new string[] 
        //    {
        //        "http://www.jonasjohn.de/snippets/csharp/",
        //        "www.jonasjohn.de/snippets/csharp/",
        //        "http://www.jonasjohn.de/",
        //        "ftp://www.jonasjohn.de/",
        //        "www.jonasjohn.de/",
        //        "http://www.sharejs.com/codes/",
        //        "https://subdomain.abc.def.jonasjohn.de/test.htm",
        //        "http://www.163.com/",
        //        "http://mail.163.com/",
        //        "http://slknate.cnblogs.com/"
        //    };

            // Test all urls with all different methods:
        //    foreach (string Url in Urls)
        //    {
        //        Console.WriteLine("Method 1: {0}", ExtractDomainNameFromURL_Method1(Url));
        //        Console.WriteLine("Method 2: {0}", ExtractDomainNameFromURL_Method2(Url));
        //        Console.WriteLine("Method 3: {0}", ExtractDomainNameFromURL_Method3(Url));
        //    }

        //    Console.ReadLine();
        //}
    }
}
