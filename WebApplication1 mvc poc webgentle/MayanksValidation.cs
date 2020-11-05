using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1_mvc_poc_webgentle
{
    public class MayanksValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value!=null)
            {
                string message = value.ToString();
                if(message.Contains("mayank"))
                {
                    return ValidationResult.Success;
                }
            }

            ErrorMessage = ErrorMessage ?? "Field must contain mayank";
            return new ValidationResult(ErrorMessage);
        }
    }
}