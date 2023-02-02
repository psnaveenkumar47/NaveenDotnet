using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateUnderstanding
{
     class Customer
    {
        int cusid;
        string cusname;
        public Customer(int id,string name)
        {
            this.cusid = id;
            this.cusname = name;
        }
        private void Display()
        {
            Console.WriteLine($"Customer ID:{cusid}\nCustomer Name:{cusname}");
        }
        public void AvailService()
        {
            PrintDelegate d=new PrintDelegate(Display);
            PrintingService.Print(d);
        }
    }
}
