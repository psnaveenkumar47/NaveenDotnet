using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp = new Employee();
            emp.FirstName = "naveen";
            emp.LastName = "kumar";
            emp.Salary = 30000;
            employees.Add(emp); 
            emp=new Employee();
            emp.FirstName = "pradeep";
            emp.LastName = "kumar";
            emp.Salary = 40000;
            employees.Add(emp);
            emp = new Employee();
            emp.FirstName = "rakesh";
            emp.LastName = "kumar";
            emp.Salary = 25000;
            employees.Add(emp);
            return employees;
        }
    }
}