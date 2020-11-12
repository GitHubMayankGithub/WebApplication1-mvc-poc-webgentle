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
        public ActionResult IndexForJquery()
        {
            return View();
        }


        [Route("LayoutIndex")]
        public ActionResult LayoutIndex()
        {
            return View("LayoutIndex");
        }
        public ActionResult CustomValidationIndex()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult CustomValidationIndex(NewEmployee newEmployee)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                return View();
            }
            return View("");
        }
        
        public ActionResult NewIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitData(NewEmployee employee)
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            return View("NewIndex");
        }

        public ActionResult Index2()
        {
            Session.Abandon();
            ViewBag.MyData = TempData["myKey"];
            TempData.Keep();
            return View();
        }
        public ActionResult Index3()
        {
          
            //ViewBag.MyData = TempData["myKey"];
            ViewBag.MyData = TempData.Peek("myKey");
            return View();
        }
        public ActionResult Index()
        {
            TempData["myKey"] = "data from tempData";

            ViewData["MyKey"] = "value for the key";

            ViewBag.MyProp = "my property from viewbag";

            ViewBag.MyList = new List<string>() { "1", "2", "abd" };
            ViewData["employeeData"] = new List<string>() { "C#", "java", "python" };

            List<Employee> employees = new List<Employee>()
            {
                new Employee(){id=1,address="jsdfg",email="gma@gmail.com",isOnline=true,name="mayank"},
                new Employee(){id=2,address="jsdfg",email="gma@gmail.com",isOnline=true,name="mayank"},
                new Employee(){id=3,address="jsdfg",email="gma@gmail.com",isOnline=true,name="mayank"},
                new Employee(){id=4,address="jsdfg",email="gma@gmail.com",isOnline=true,name="mayank"},
                new Employee(){id=5,address="jsdfg",email="gma@gmail.com",isOnline=true,name="mayank"}
            };

            ViewBag.MyEmployeeList = employees;
            //ViewData["employeeData"] = employees;

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

        public ActionResult DemoViewData()
        {
            ViewData["MyKey"] = "value for the key";
            return View();
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