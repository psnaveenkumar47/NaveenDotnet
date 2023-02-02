using System;

class Employee
{
    static public readonly int Emp_Id = 1;
    int EmployeeId;
    public string Emp_Name;
    public string PrintSalarySlip()
    {
        //this.TotalSalary=TS;
        EmployeeSalary();
        return string.Format(" Employee Id:{0}\n Employee Name: {1} \n Basic Salary: {2}\n Dearness Allowance: {3}\n House Rent Allowance: {4}\n Total Salary: {5}\n", EmployeeId, Emp_Name, _Basic, _Da, _Hra, TotalSalary);

    }
}
class MainClass
{ 
    static void Main()
    {

        int n;
        int c = 0;
        char ch;
        Employee[] Emparr = new Employee[10];
        do
        {
            Console.WriteLine(" 1.Add an Employee \n 2.Display the data \n 3.Exit ");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter the Name of an Employee :");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Enter the Da of an Employee :");
                    decimal da = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the HRA of an Employee :");
                    decimal hra = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Basic of an Employee :");
                    decimal basic = Convert.ToInt32(Console.ReadLine());
                    Emparr[c++] = new Employee(Name, da, hra, basic);
                    break;
                case 2:
                    for (int i = 0; i < c; i++)
                    {
                        Console.WriteLine(Emparr[i].PrintSalarySlip());
                        Console.WriteLine("---------------------------------------------");
                    }
                    break;
                case 3:
                    Console.WriteLine("Thnak you Program is now Exited	");
                    Environment.Exit(0);
                    break;

            }

            Console.WriteLine("Do you want to continue(Y|N)");
            ch = Console.ReadLine()[0];
        } while (ch == 'Y' || ch == 'y');

    }
    public Employee(string Name, decimal DEA, decimal HRA, decimal Basicsalary)
    {
        this.Emp_Name = Name;
        this._Da = DEA;
        this._Hra = HRA;
        this._Basic = Basicsalary;
        EmployeeId = Emp_Id++;
    }
    public decimal EmployeeSalary()
    {

        TotalSalary = _Da + _Hra + _Basic;
        return TotalSalary;

    }
 
}
