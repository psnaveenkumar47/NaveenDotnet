using System;

namespace DelegateUnderstanding
{
     class Employee
    {
        int empid;
        string empname;
        int basic, da, hra;
        public Employee(int id,string name,int basic,int da,int hra)
        {
            this.empid = id;
            this.empname = name;    
            this.basic = basic; 
            this.da = da;   
            this.hra = hra; 

        }
        private int salary
        {
            get
            {
                return basic + da + hra;
            }
        }
        private void SalarySlip()
        {
            Console.WriteLine($"Emp Id: {empid}\nEmp Name: {empname}\nSalary: {salary}");
        }
        public void GenerateSalarySlip()
        {
            PrintingService.Print(SalarySlip);
        }
    }
}
