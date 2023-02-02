using System;
using System.Collections;
namespace StudentException
{

    class Student
    {
        static int ID = 1001;
        public readonly int studentid;
        private String name;
        private int marks,count;
        Hashtable stutable=new Hashtable();
        public Student (Hashtable sh)
        {
            this.name = name;
            this.marks = marks;
            this.stutable = sh;
            studentid = ID++;
            // count=sh.Count;
        }
        public void PrintDetails()
        {
            // Console.Write("Student Id:{0}\nName of a Student:{1}\nMarks of Student:{2}",ID, name, marks);
            foreach (DictionaryEntry de in stutable)
            {
                
                Console.WriteLine($"\nStudent ID:{studentid}\nStudent Name:{de.Key}\nStudent Marks:{de.Value}");
            }
            
        }

    }
    class MainClass
    {

        static int option, counter, index, studentkey;
        static char choice;
        static string studentname;
        static int marks;
       static Hashtable studenttable=new Hashtable();
        static Student studeontobject = new Student(null);

        static void Main()
        {
            do
            {
                Console.WriteLine("The Options Are:");
                Console.WriteLine(" 1.Add an Student \n 2.Display the complete Students data\n 3.Display particular Student details \n 4.Exit ");
                Console.Write("Choose an option to continue:");
                option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.Write("Enter Name of a Student:");
                        studentname = Console.ReadLine();
                        Console.Write("Enter Marks of a Student:");
                        marks = Convert.ToInt32(Console.ReadLine());
                        
                        try
                        {
                            if (marks < 0)
                            {
                                throw new MarksNegaticeException();
                            }
                            else if (marks > 100)
                            {
                                throw new MarksOverException();
                            }
                            else
                            {
                                studenttable.Add(studentname, marks);
                            }
                        }
                        catch (MarksNegaticeException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (MarksOverException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        studeontobject = new Student(studenttable);
                        Console.WriteLine("Details Added");
                        break;
                    case 2:
                        Console.WriteLine("-------------THE DETAILS ARE---------------");
                       
                        studeontobject.PrintDetails();
                       
                        break;
                    case 3:
                        Console.Write("Enter the Id of an Particular Student:");
                        studentkey = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n-------------THE DETAILS ARE---------------");
                        
                        break;
                    case 4:
                        Console.WriteLine("Program is now Exicited");
                        Environment.Exit(0);
                        break;
                }
               
                Console.Write("\nDo you want to continue:");
                choice = Console.ReadLine()[0];
            } while (choice == 'y' || choice == 'Y');
        }
    }
}