//using Printer;
namespace DelegateAssignment
{
    public class Student
    {
        int studentid;
        string studentname;
        public Student(int id, string name)
        {
            this.studentid = id;
            this.studentname = name;
        }
        private void Display()
        {
            Console.WriteLine($"Student ID:{studentid}\nStudent Name:{studentname}");
        }
        public void Print()
        {
            PrintDelegate d = new PrintDelegate(Display);
            PrinterLibrary.Print(d);
        }
    }
}