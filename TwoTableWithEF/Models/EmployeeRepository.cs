using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TwoTableWithEF.DataAccessLayer;
using TwoTableWithEF.Models;

namespace TwoTableWithEF.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        EmployeeDataLayer employeeDal;
        private int _nextId = 1;
        public EmployeeRepository()
        {
            employeeDal = new EmployeeDataLayer();
        }
        public IEnumerable<Employee> GetAll()
        {
            return employeeDal.Employees.ToList();
        }
        public Employee Get(int id)
        {
            return employeeDal.Employees.ToList().Find(x => x.EmployeeId == id);
        }
        public Employee AddEmployee(Employee emp)
        {
            if (emp == null)
            {
                throw new ArgumentNullException("Employee");
            }
            emp.EmployeeId = _nextId++;
            employeeDal.Employees.Add(emp);
            employeeDal.SaveChanges();
            return emp;
        }
        public bool Update(Employee emp)
        {
            if (emp == null)
            {
                throw new ArgumentNullException("Employee");
            }
            Employee found = employeeDal.Employees.Find(emp.EmployeeId);
            if (found == null)
            {
                return false;
            }
            found.EmployeeName = emp.EmployeeName;
            found.EmployeeDepartment = emp.EmployeeDepartment;
            found.EmployeeSalary = emp.EmployeeSalary;
            employeeDal.SaveChanges();
            return true;

        }
        public void Remove(int id)
        {
            Employee found = employeeDal.Employees.Find(id);
            if (found != null)
            {
                throw new ArgumentNullException("Employee");
            }
            employeeDal.Employees.Remove(found);
            employeeDal.SaveChanges();
        }

    }
}