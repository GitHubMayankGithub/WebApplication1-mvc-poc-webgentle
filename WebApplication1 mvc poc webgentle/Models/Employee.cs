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
        [Required]
        public string name { get; set; }

        [Required]
        public string address { get; set; }


        public bool isOnline { get; set; }


        //[Required]
        [EmailAddress]
        public string email { get; set; }

       //[Required]
        [Display(Name = "Date of Birth ")]
        [DataType(DataType.Date)]
        public DateTime dob { get; set; }

      //  [Range(18,100)]
        public int Age { get; set; }
    }
}