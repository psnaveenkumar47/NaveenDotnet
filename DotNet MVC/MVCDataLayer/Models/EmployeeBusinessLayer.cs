using System;
using System.Collections.Generic;
using System.Linq;
using MVCDataLayer.DataAccessLayer;
using MVCDataLayer.ViewModel;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Mvc;
using System.Data.Entity;
using MVCDataLayer.Models;

namespace MVCDataLayer.Models
{
    public class EmployeeBusinessLayer
    {
        MyCompanyContext salesDal;
        public EmployeeBusinessLayer()
        {
            salesDal = new MyCompanyContext();
        }
        public List<Employee> GetEmployees()
        {
            return salesDal.Employees.ToList();
        }
        public Employee SaveEmployee(Employee e)
        {
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        }

        public bool IsValidUser(UserDetails u)
        {

            if(u.UserName=="naveen" && u.Password=="naveen")
            {
                return true;
            }
            else
            {
                return false;
            }          
               

        }
    }
}