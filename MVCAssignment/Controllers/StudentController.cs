using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAssignment.Models;
using MVCAssignment.ViewModel;

namespace MVCAssignment.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult GetStudents()
        {
            StudentRecordViewModel studentRecords = new StudentRecordViewModel();
            List<StudentViewmodel> studentViewModels = new List<StudentViewmodel>();
            StudentBusinessLayer studentBal = new StudentBusinessLayer();
            List<Student> student = studentBal.GetEmployees();
            foreach (Student stu in student)
            {
                StudentViewmodel svm = new StudentViewmodel();
                svm.StudentId = stu.StudentId;
                svm.StudentName = stu.FirstName + " " + stu.LastName;
                svm.age = (int)stu.age;
                /*
                if (stu.Salary > 13000)
                {
                    svm.SalaryColor = "yellow";
                }
                else
                {
                    svm.SalaryColor = "green";
                }
                */
                studentViewModels.Add(svm);
            }
            studentRecords.MyStudent = studentViewModels;
            return View(studentRecords);
        }

        public ActionResult AddNew()
        {

            // return View("CreateEmployee");
            return View("CreateEmployee", new CreateStudentViewModel());
        }

        public ActionResult SaveEmployee(Student e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    if (ModelState.IsValid)
                    {
                        StudentBusinessLayer stubal = new StudentBusinessLayer();
                        stubal.SaveEmployee(e);
                        return RedirectToAction("GetEmployees");
                    }
                    else
                    {
                        CreateStudentViewModel vm = new CreateStudentViewModel();
                        vm.FirstName = e.FirstName;
                        vm.LastName = e.LastName;
                        /*
                        if (e.Salary.HasValue)
                        {
                            vm.Salary = e.Salary.ToString();
                        }
                        else
                        {
                            vm.Salary = ModelState["Salary"].Value.AttemptedValue;
                        }
                        */
                        return View("StudentRegister");
                    }
                case "Cancel":
                    return RedirectToAction("GetEmployees");

            }
            return new EmptyResult();
        }
        public bool Update(Student stu)
        {
            if (stu == null)
            {
                throw new ArgumentNullException("Student");
            }
            Student found = stu.Find(stu.StudentId);
            if (found == null)
            {
                return false;
            }
            stu.StudentId = stu.StudentId;
            found.FirstName = stu.FirstName;
            stu.SaveChanges();
            return true;

        }
        public void Delete(int id)
        {
            Student found = Student.Find(id);
            if (found != null)
            {
                throw new ArgumentNullException("Student");
            }
            Student.Remove(found);
            stu.SaveChanges();
        }
        [Authorize]
        public string SayHello()
        {
            return "Hello";
        }
    }
}