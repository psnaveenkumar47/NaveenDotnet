using System;
namespace StudentAbstraction
{
   abstract class Student
    {
        String name;
        String studentcalss;
        public abstract void getPercentage();
        
        public static void getTotalNoStudent()
        {

        }
        
    }
    class ScienceStudent:Student
    {
         int physicsmarks, chemistrymarks, mathsmarks,studentclass;
        string studentname;
        static int noOfStudents;
         double sciencepercentage;
        public ScienceStudent(string name, int stuclass, int physics, int chemistry, int maths)
        {
            this.studentname = name;
            this.studentclass = stuclass;
            this.physicsmarks=physics;
            this.chemistrymarks=chemistry;
            this.mathsmarks =maths;
        }
        public override void getPercentage()
        {
            sciencepercentage = (physicsmarks + chemistrymarks + mathsmarks) / 3;
            Console.WriteLine("percentage for science student is: ",sciencepercentage);

        }
    }
    class HistoryStudent : Student
    {
        int historymarks, civicsmarks, studentclass;
        string studentname;
        static int noOfStudents;
        static double historypercentage;
        public HistoryStudent(string name,int stuclass, int historymarks, int civicsmarks)
        {
            this.historymarks = historymarks;
            this.civicsmarks = civicsmarks;
            this.studentname = name;
            this.studentclass = stuclass;
        }

        public override void getPercentage()
        {
            historypercentage= (civicsmarks + noOfStudents) / 2;
            Console.WriteLine("percentage for history student is: ", historypercentage);

        }

    }
    class AllStudent : Student
    {
        int historymarks, civicsmarks,studentclass,physicsmarks,chemistrymarks,mathmarks;
        string studentname;
        static int noOfStudents;
        static double totalpercentage;
        public AllStudent(string name,int stuclass,int physics, int chemistry, int maths,int history, int civics)
        {
            this.studentname = name;
            this.studentclass = stuclass;
            this.physicsmarks= physics;
            this.chemistrymarks = chemistry;
            this.mathmarks = maths;
            this.historymarks = history;
            this.civicsmarks = civics;
        }

            public override void getPercentage()
        {
            totalpercentage = (physicsmarks + chemistrymarks + mathmarks + historymarks + civicsmarks) / 5;
            Console.WriteLine("percentage for All student is: ", totalpercentage);

        }

    }
    class MainClass
    {
        static int option, counter, physics, chemistry, maths, history, civics, studentclass;
        //int counter=0;
        static char choice;
        static string studentname;
        static int age;
        public static Student[] students = new Student[10];
        static void Main()
        {
            do
            {
                Console.WriteLine("The Options Are:");
                Console.WriteLine(" 1.Science Student \n 2.History Student \n 3.All Student \n 4.Exit ");
                Console.Write("Choose an option to continue:");
                option = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter name of a Student");
                studentname = Console.ReadLine();
                Console.Write("Enter Student Class");
                studentclass = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Write("Enter Student physics marks");
                        physics = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Student chemistry marks");
                        chemistry = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Student maths marks");
                        maths = Convert.ToInt32(Console.ReadLine());
                        ScienceStudent scienceobject = new ScienceStudent(studentname,studentclass,physics,chemistry,maths);
                       scienceobject.getPercentage();
                        break;
                    case 2:
                        Console.Write("Enter Student history marks");
                        history = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Student civics marks");
                        civics = Convert.ToInt32(Console.ReadLine());
                        HistoryStudent historyobject = new HistoryStudent(studentname, studentclass, history, civics);
                        historyobject.getPercentage();

                        break;
                    case 3:
                        Console.Write("Enter Student physics marks");
                        physics = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Student chemistry marks");
                        chemistry = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Student maths marks");
                        maths = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Student history marks");
                        history = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Student civics marks");
                        civics = Convert.ToInt32(Console.ReadLine());
                        AllStudent allstuobject = new AllStudent(studentname, studentclass, physics, chemistry, maths,history,civics);
                        allstuobject.getPercentage();
                        break;
                    case 4:
                        Console.WriteLine("Program is now Exicited");
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Do you want to continue (Y/N)");
                choice = Console.ReadLine()[0];
            } while (choice == 'y' || choice == 'Y');
        
        }
    }
    
}