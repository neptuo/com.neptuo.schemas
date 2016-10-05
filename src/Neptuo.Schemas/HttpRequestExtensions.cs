using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Web
{
    public static class HttpRequestExtensions
    {
        public static string ResolveUrl(this HttpRequestBase request, string url)
        {
            if (!url.StartsWith("~/"))
                return url;

            return VirtualPathUtility.ToAbsolute(url);
        }
    }
}