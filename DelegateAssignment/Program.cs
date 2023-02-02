using CustomerLibrary;
using StudentLibrary;
using DelegateLibrary;
using EmployeeLibrary;
using Printer; 
using System;
namespace DelegateAssignment
{
    class MainClass
    {
        static void Main()
        {
            Customer customerobj = new Customer(1001,"naveen");
            Employee employeeobj = new Employee(1002, "sumit");
            Student stuedntobj =new Student(1003, "mukesh");
            customerobj.Print();
            employeeobj.Print();
            stuedntobj.Print();
        }
    }
}