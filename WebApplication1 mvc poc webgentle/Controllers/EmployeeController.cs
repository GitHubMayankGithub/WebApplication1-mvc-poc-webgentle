using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1_mvc_poc_webgentle.Controllers
{
    public class EmployeeController : Controller
    {
        [Route("Employee")]
        public ActionResult GetList()
        {
            return View();
        }

        [Route("NewEmployee")]
        public ActionResult AddEmployee()
        {
            return View("AddEmployee");
        }


        // GET: Employee
        public string EmployeeProfile(int Id)
        {
            //string profile = "";
            if(Id==1)
            {
                return "profile of user-1";
            }
            else if(Id==2)
            {
                return "profile of user-2";
            }
            else if (Id == 3)
            {
                return "profile of user-3";
            }
            else
            {
                return "no user found";
            }
          
        }

        public string Address(int Id,int? code)
        {
            return "Id : "+Id+" Code : "+code;
        }

        public string Address1()
        {
            return "test Action link redirect from another controller is successfull";
        }

        public string ParamteeWithActionLink(string str)
        {
            return str;
        }
    }
}