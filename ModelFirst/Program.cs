using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDl MyData = new MyDl();
            Person p = new Person();
            //p.ID = 101;
            p.Name = "Suraj";
            p.City = "Bangalore";
            p.Country = "India";
            MyData.Persons.Add(p);
            MyData.SaveChanges();
            Console.WriteLine("------------");
        }
    }
}
