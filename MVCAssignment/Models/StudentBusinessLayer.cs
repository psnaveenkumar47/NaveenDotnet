    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCAssignment.DataAccessLayer;

namespace MVCAssignment.Models
{
    public class StudentBusinessLayer
    {
        MyCompanyContext stuDal;
        public StudentBusinessLayer()
        {
            stuDal = new MyCompanyContext();
        }
        public List<Student> GetEmployees()
        {
            return stuDal.Students.ToList();
        }
        public Student SaveEmployee(Student e)
        {
            stuDal.Students.Add(e);
            stuDal.SaveChanges();
            return e;
        }
        public bool IsValidUser(UserDetails u)
        {
            if (u.UserID == "naveen" && u.Password == "naveen")
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