using System;
namespace IcomparableEmployee
{
    class Employee:IComparable
    {
        private int _id;
        public Employee(int id)
        {
            this._id = id;
        }
        public int CompareTo(object obj)
        {
            Employee employ=(Employee)obj;
            return this._id.CompareTo(employ._id);
        }
        public override string ToString()
        {
            return this._id.ToString();
        }
    }
    class MainClass
    {
        static void Main()
        {
            int[] intarray = { 4, 9, 3, 4, 6, 7, 8, 9, 3, 5 };
            Array.Sort(intarray);
            foreach(int i in intarray)
            {
                Console.WriteLine(i);
            }
            Employee[] employarray = new Employee[10];
            for(int i=10;i>0;i--)
            {
                employarray[i - 1] = new Employee(i);
            }
            Array.Reverse(employarray);
            Array.Sort(employarray);
            foreach(Employee employ in employarray)
            {
                Console.WriteLine(employ);
            }
        }
    }
}