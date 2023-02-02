using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateUnderstanding
{
     class Product
    {
            int ProID;
            string Proname;
            public Product(int id,string name)
            {
                this.ProID = id;
                this.Proname=  name;
            }
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Id: {ProID}\nProduct Name:{Proname}");
        }
        public void UseService()
        {
            PrintDelegate d = new PrintDelegate(DisplayProductDetails);
            PrintingService.Print(d);
        }

        
    }
}
