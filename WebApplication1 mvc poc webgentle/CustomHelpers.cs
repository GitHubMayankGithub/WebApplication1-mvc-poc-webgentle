﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1_mvc_poc_webgentle
{
    public static class CustomHelpers
    {

        public static IHtmlString Image(string src,string alt)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}'</img>", src, alt));
        }
    }
}