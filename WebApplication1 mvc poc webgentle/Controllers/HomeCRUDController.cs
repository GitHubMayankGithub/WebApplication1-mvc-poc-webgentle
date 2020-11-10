using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Model;
using MyApp.DB.DbOperations; 

namespace WebApplication1_mvc_poc_webgentle.Controllers
{
    public class HomeCRUDController : Controller
    {
        EmployeeRepository employeeRepository = null;

        public HomeCRUDController()
        {
            employeeRepository = new EmployeeRepository();
        }

        // GET: HomeCRUD
        public ActionResult Create()
        {

            return View();
        }
        
        [HttpPost]
        public ActionResult Create(EmployeeModel employeeModel)
        {
            if(ModelState.IsValid)
            {
                int id=employeeRepository.AddEmployee(employeeModel);

                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.IsSuccess = "Data added successfully !";
                }
            }
           
            return View();
        }
    }
}