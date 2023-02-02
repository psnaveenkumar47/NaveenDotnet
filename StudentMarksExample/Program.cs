using System;
class Student
{
	static int id = 1001;
	public readonly int rollno;
	string studentname, branch;
	int studentclass,SEM,sum,average;
	int[] studentmarks = new int[5];
	public Student(string name,int grade, int sem,string branch, int[] marks,int sum)
	{
		this.studentname = name;
		this.studentclass = grade;
		this.SEM = sem;
		this.branch = branch;
		this.studentmarks = marks;
		this.sum = sum;
		average = sum / 5;
	}
	public string DisplayResult()
	{
		for(int i=0;i<5;i++)
        {
            if(studentmarks[i]<35)
            {
				return String.Format("failed in {0} subject", i+1);
            }			
        }
		if (average < 50)
		{
			return String.Format("Average failed ");
		}
		return String.Format("Passed in all subjects");
	}
}
class MainClass
{

	static char choice;
	static string studentname,branch;
	static int studentgrade,SEM,sum=0,average;
	static int[] marks = new int[5];
	static void Main()
	{
		do
		{
			AddStudent();
			Console.WriteLine(" Do you want to continue (Y/N)");
			choice = Console.ReadLine()[0];
		} while (choice == 'y' || choice == 'Y');
	}
	
	static void AddStudent()
	{
		Console.Write("Enter Name of a Student:");
		studentname = Console.ReadLine();
		Console.Write("Enter Student Class:");
		studentgrade = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter semester of a Student:");
		SEM = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter Branch of a Student:");
		branch = Console.ReadLine();
		for(int i=0; i<5;i++)
        {
			Console.Write("Enter marks for subject {0}:", i+1);
			marks[i] = Convert.ToInt32(Console.ReadLine());
			sum += marks[i];
        }
		Student s1 = new Student(studentname, studentgrade, SEM, branch,marks,sum);
		Console.WriteLine(s1.DisplayResult());
			}
}