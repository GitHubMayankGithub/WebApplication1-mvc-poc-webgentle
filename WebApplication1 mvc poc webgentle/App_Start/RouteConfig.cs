using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1_mvc_poc_webgentle
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "allStudents",
                url: "students",
                defaults: new { controller = "Student", action = "GetAllStudents", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Students",
                url: "students/{id}",
                defaults: new { controller = "Student", action = "GetStudent", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "StudentsAddress",
                url: "students/{id}/Address",
                defaults: new { controller = "Student", action = "GetStudentAddress", id = UrlParameter.Optional },
                constraints:new { id= @"\d+" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
