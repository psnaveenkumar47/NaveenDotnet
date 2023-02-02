using System;
namespace IComparableStudent
{
    struct student:IComparable
    {
        public int marks;
        public student(int i)
        {
            this.marks = i;
        }
        public int CompareTo(object o)
        {
            student s = (student)o;
            return this.marks.CompareTo(s.marks);
        }
        public override string ToString()
        {
            return this.marks.ToString();
        }
    }
    class MainClass
    {
        static void Main()
        {
            int[] intarray = { 30, 46, 76, 34, 67 };
            student[] studentarray=new student[3];
            studentarray[0] = new student(53);
            studentarray[1] = new student(88);
            studentarray[2] = new student(70);
            Array.Sort(studentarray);
            foreach(student s in studentarray)
            {
                Console.WriteLine(s.ToString());
            }
            Array.Sort(intarray);
            foreach(int i in intarray)
            {
                Console.WriteLine(i);
            }
            int[] myarray=new int[3];
            myarray[0] = 30;
            myarray[1] = 23;
            myarray[2] = 56;
            IComparable i1 = myarray[0];
            IComparable i2 = myarray[1];
            Console.WriteLine(i1.CompareTo(i2));
        }
    }
}