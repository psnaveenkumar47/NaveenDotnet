//using Printer;
namespace DelegateAssignment
{
    public class Customer
    {
        int customerid;
        string customername;
        public Customer(int id, string name)
        {
            this.customerid = id;
            this.customername = name;
        }
        private void Display()
        {
            Console.WriteLine($"Customer ID:{customerid}\nCustomer Name:{customername}");
        }
        public void Print()
        {
            PrintDelegate d = new PrintDelegate(Display);
            PrinterLibrary.Print(d);
        }
    }
}