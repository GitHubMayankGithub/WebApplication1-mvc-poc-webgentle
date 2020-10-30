using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_mvc_poc_webgentle.Models;

namespace WebApplication1_mvc_poc_webgentle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = GetEmployee();
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("AboutRename");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CustomView()
        {
            ViewBag.Message = "Your contact page.";

            return View("~/Views/customView/customView.cshtml");
        }

        private Employee GetEmployee()
        {
            return new Employee()
            {
                id = 1,
                name="rahul",
                address="allahabad"


            };
        }
    }
}