using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TwoTableWithEF.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeDepartment { get; set; }
        public decimal EmployeeSalary { get; set; }
    }
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
       
        [Display(Name = "Employee")]
        public virtual int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employees { get; set; }
    }
}