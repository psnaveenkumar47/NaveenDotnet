using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCAssignment.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Enter StudentID")]
        [FirstNameValidation]
        public string FirstName { get; set; }
        [StringLength(10, ErrorMessage = "Last Name length sould not be greater than 10")]
        public string LastName { get; set; }
        public int ?age { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
    public class FirstNameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Please provide First Name");
            }
            else
            {
                if (value.ToString().Contains("@"))
                {
                    return new ValidationResult("First Name should not Contain @");
                }
            }
            return ValidationResult.Success;
        }
    }

}