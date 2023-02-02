using System;
namespace Destructor
{
    class Employee
    {
        public int ID;
        public Employee(int id)
        {
            this.ID = id;
            Console.WriteLine($"Constructor for ID {this.ID}");
        }
        ~Employee()
        {
            Console.WriteLine($"Desructor for Employee {this.ID}");
        }
    }
}