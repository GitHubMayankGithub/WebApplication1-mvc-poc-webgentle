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
            //var data = GetEmployee();
            Employee employee = new Employee()
            {
                name = "rahul",
                address = "allahabad",
                dob = DateTime.Now,
                id = 22,
                email = "email@gmail.com",
                isOnline = true
            };
            return View(employee);
        }

        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            return View(emp);
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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Employee GetEmployee()
        {
            return new Employee()
            {
                name="rahul",
                address="allahabad",
                dob=DateTime.Now,
                id=22,
                email="email@gmail.com",
                isOnline=true


            };
        }

        public string ParamteeWithActionLink(string name=null)
        {
            return name;
        }
        public ActionResult Edit()
        {
            return View();
        }  [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            return View(emp);
        }
    }
}