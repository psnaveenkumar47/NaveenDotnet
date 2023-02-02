using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloMVC.ViewModels;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.MyTitle = "Test controller index page";
            return View();
        }
        public class Customer
        {
            public string CustomerName { get; set; }
            public string Address { get; set; }
            public override string ToString()
            {
                return this.CustomerName + "|" + this.Address;
            }
        }



        public string SayHello()
        {
            return "Hy Dude I am Learning MVC";
        }

        public string NonHello()
        {
            return string.Empty;
        }

        public ActionResult NoGreeting()
        {
            return new EmptyResult();
        }

        public string SimpleMethod()
        {
            return "Hi Dude I am not an Action Method";
        }

        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "Raja";
            c.Address = "Hassan";
            return c;
        }

        public ActionResult GetMyView()
        {
            return View("MyView");//It will Look MyView in Views/Test
        }

        public ActionResult GetView()
        {
            return View();//It will look for GetView which is action name
        }
        public ActionResult GetEmployeeView()
        {
            return View();
        }
      public ActionResult GetEmployee()
        {
            Employee emp = new Employee();
            emp.FirstName = "naveen";
            emp.LastName = "kumar";
            emp.Salary = 30000;
            ViewBag.MyEmployee = emp;
            return View();
        }
        public ActionResult GetAnotherEmployee()
        {
            Employee emp = new Employee();
            emp.FirstName = "naveen";
            emp.LastName = "kumar";
            emp.Salary = 30000;
            ViewBag.MyEmployee = emp;
            return View();
        }
        public ActionResult EmployeeTypedView()
        {
            Employee emp=new Employee();
            emp.FirstName = "naveen";
            emp.LastName = "Kumar";
            emp.Salary = 30000;
            return View(emp);
        }
        public ActionResult EmployeeListView()
        {
            AnotherEmployeeListViewModel emplistviewmodel=new AnotherEmployeeListViewModel();
            EmployeeBusinessLayer empbal = new EmployeeBusinessLayer();
            List<Employee> employees=empbal.GetEmployees();
            List<AnotherEmployeeViewModel> empviewmodel = new List<AnotherEmployeeViewModel>();
         foreach(Employee employee in employees)
            {
                AnotherEmployeeViewModel empViewModels = new AnotherEmployeeViewModel();
                empViewModels.EmployeeName = employee.FirstName + " " + employee.LastName;
                empViewModels.Salary = employee.Salary.ToString("C");
                if(employee.Salary>15000)
                {
                    empViewModels.SalaryColor = "yellow";
                }
                else
                {
                    empViewModels.SalaryColor = "green";
                }
                empviewmodel.Add(empViewModels);
            }
            emplistviewmodel.MyEmployees = empviewmodel;
            emplistviewmodel.UserName = "Admin";
            return View("AnotherEmployeeListView",emplistviewmodel);
        }
    }
}