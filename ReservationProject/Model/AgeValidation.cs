using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class AgeValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
           if(DateTime.Now.Year - Convert.ToDateTime(value).Year >= 18)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("The guest must be in the legal age to create reservation.");
        }
    }
}
