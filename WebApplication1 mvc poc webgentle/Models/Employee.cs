using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1_mvc_poc_webgentle.Models
{
    public class Employee
    {
        public int id { get; set; }
        [Display(Name ="Name")]
        public string name { get; set; }
        public string address { get; set; }

        public bool isOnline { get; set; }
        public string email { get; set; }

        [Display(Name = "Date of Birth ")]
        [DataType(DataType.Date)]
        public DateTime dob { get; set; }
    }
}