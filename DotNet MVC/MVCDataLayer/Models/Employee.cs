﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MVCDataLayer.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="Enter First Name")]
        [FirstNameValidation]
        public string FirstName { get; set; }
        [StringLength(10,ErrorMessage ="Last Name length sould not be greater than 10")]
        public string LastName { get; set; }
        public int ?Salary { get; set; }

    }
    public class FirstNameValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value == null)
            {
                return new ValidationResult("Please provide First Name");
            }
            else
            {
                if(value.ToString().Contains("@"))
                {
                    return new ValidationResult("First Name should not Contain @");
                }
            }
            return ValidationResult.Success;
        }
    }
}