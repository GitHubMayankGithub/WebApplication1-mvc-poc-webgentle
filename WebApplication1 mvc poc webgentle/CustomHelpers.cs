    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1_mvc_poc_webgentle
{
    public static class CustomHelpers
    {
        /// <summary>
        /// custom helpers using static class
        /// </summary>
        /// <param name="src"></param>
        /// <param name="alt"></param>
        /// <returns></returns>
        public static IHtmlString Image(string src,string alt)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}'</img>", src, alt));
        }


        /// <summary>
        /// /// custom helpers using extension method
        /// <param name="src"></param>
        /// <param name="alt"></param>
        /// <returns></returns>
        public static IHtmlString Img(this HtmlHelper htmlHelper,string src,string alt)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}'</img>", src, alt));
        }

        /// <summary>
        /// custom helpers using  Tag builder
        /// </summary>
        /// <param name="htmlHelper"></param>
        /// <param name="src"></param>
        /// <param name="alt"></param>
        /// <returns></returns>
        public static IHtmlString ImageTag(this HtmlHelper htmlHelper,string src,string alt)
        {
            TagBuilder tag = new TagBuilder("img");
            tag.Attributes.Add("src", src);
            tag.Attributes.Add("alt", alt);
            return new MvcHtmlString(tag.ToString());
        }
    }
}