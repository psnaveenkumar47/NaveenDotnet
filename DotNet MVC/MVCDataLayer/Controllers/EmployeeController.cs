using MVCDataLayer.ViewModel;
using System.Collections.Generic;
using MVCDataLayer.Models;
using System.Web.Mvc;

namespace MVCDataLayer.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult GetEmployees()
        {
            EmployeeRecordsViewModel empRecords=new EmployeeRecordsViewModel();
           List<EmployeeViewModel>empViewModels=new List<EmployeeViewModel>();
            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
            List<Employee> employees = empBal.GetEmployees();
            foreach(Employee emp in employees)
            {
                EmployeeViewModel evm = new EmployeeViewModel();
                evm.EmployeeId = emp.EmployeeId;
                evm.EmployeeName = emp.FirstName + " " + emp.LastName;
                evm.Salary = (int)emp.Salary;
                if(emp.Salary>13000)
                {
                    evm.SalaryColor = "yellow";
                }
                else
                {
                    evm.SalaryColor = "green";
                }
                empViewModels.Add(evm);
            }
            empRecords.MyEmployees = empViewModels;
            return View(empRecords);
        }

        public ActionResult AddNew()
        {

            // return View("CreateEmployee");
            return View("CreateEmployee", new CreateEmployeeViewModel());
        }

        public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    if(ModelState.IsValid)
                    {
                        EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();
                        empBal.SaveEmployee(e);
                        return RedirectToAction("GetEmployees");
                    }
                    else
                    {
                        CreateEmployeeViewModel vm = new CreateEmployeeViewModel();
                        vm.FirstName = e.FirstName;
                        vm.LastName = e.LastName;
                        if(e.Salary.HasValue)
                        {
                            vm.Salary = e.Salary.ToString();
                        }
                        else
                        {
                            vm.Salary = ModelState["Salary"].Value.AttemptedValue;
                        }
                        return View("CreateEmployee");
                    }
                case "Cancel":
                    return RedirectToAction("GetEmployees");
                        
             }
            return new EmptyResult();
        }
        [Authorize]
        public string SayHello()
        {
            return "Hello";
        }
    }
}