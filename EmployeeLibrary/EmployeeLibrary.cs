//using Printer;
namespace DelegateAssignment
{
    public class Employee
    {
        int Employeeid;
        string Employeename;
        public Employee(int id, string name)
        {
            this.Employeeid = id;
            this.Employeename = name;
        }
        private void Display()
        {
            Console.WriteLine($"Employee ID:{Employeeid}\nEmployee Name:{Employeename}");
        }
        public void Print()
        {
            PrintDelegate d = new PrintDelegate(Display);
            PrinterLibrary.Print(d);
        }
    }
}