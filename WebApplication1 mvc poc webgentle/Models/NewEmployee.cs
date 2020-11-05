using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1_mvc_poc_webgentle.Models
{
    public class NewEmployee
    {
        //[Required(ErrorMessage ="Please Enter your First Name")]
        [MayanksValidation(ErrorMessage ="Mayank is required")]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }
    }
}