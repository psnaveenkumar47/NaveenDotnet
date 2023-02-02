using System;
namespace IComparableExplanation
{
    struct student : IComparable
    {
        public int marks;
        public int CompareTo(object obj)
        {
            student s = (student)obj;
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
            int i = 10, j = 20;
            Console.WriteLine(i.CompareTo(j));
            student s, p;
            s.marks = 10;
            p.marks = 30;
            Console.WriteLine(s.CompareTo(p));
            int[] intarray = new int[5] { 46, 34, 54, 23, 76 };
            Array.Sort(intarray);
            foreach(int a in intarray)
            {
                Console.WriteLine(a);
            }
            student[] students=new student[5];
            students[0].marks = 46;
            students[1].marks = 23;
            students[2].marks = 78;
            students[3].marks = 28;
            students[4].marks = 66;
            Array.Sort(students);
            foreach(student stu in students)
            {
                Console.WriteLine(stu.marks + " ");
            }
        } 
    } 
}