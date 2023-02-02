//using DelegateUnderstnding;
using System;
namespace DelegateUnderstanding
{
    class MainClass
    {
        static void Main()
        {
            Customer Cus = new Customer(101, "naveen");
            Product pro = new Product(112, "tata");
            Employee emp = new Employee(1001, "naveen", 34567, 7654, 4567);
            Console.WriteLine("-------Customer--------");
            Cus.AvailService();
            Console.WriteLine("-------Products-------");
            pro.UseService();
            Console.WriteLine("-------Employee-------");
            emp.GenerateSalarySlip();
        }
    }
}