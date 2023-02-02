using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableSorting
{
    public struct student : IDoCompare
    {
        public int id;
        public student(int id)
        {
            this.id = id;
        }
        public int DoComparision(object p)
        {
            student s = (student)p;
            return this.id.CompareTo(s.id);
        }

        public override string ToString()
        {
            return id.ToString();
        }
    }
    class MainClass
    {
        static void Main()
        {
            student[] studentarray = new student[5];
            studentarray[0] = new student(34);
            studentarray[1] = new student(89);
            studentarray[2] = new student(66);
            studentarray[3] = new student(76);
            studentarray[4] = new student(80);
            utilities.Sort(studentarray);
            foreach (student s in studentarray)
            {
                Console.Write(s + " ");
            }    
            {

            }
        }
    }
}
