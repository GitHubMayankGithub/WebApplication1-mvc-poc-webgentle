using System.Web;
using System.Web.Mvc;

namespace WebApplication1_mvc_poc_webgentle
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
