using System;
namespace GarbageCollection
{
    class MainClass
    {
        static void Main()
        {
            using (Employee e1=new Employee(1))
            {
                e1.Salary = 1000;
                e1.WorkStatus();
                e1.IncrementSalary(2000);
            }
            using (Employee e2=new Employee(2))
            {
                e2.Salary = 15000;
                e2.WorkStatus();
                e2.IncrementSalary(1000);
            }
        }
    }
}