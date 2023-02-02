class Employee
{
    private int employeeId=101,id;
    public  String _name;
   protected int _basic, _da, _hra;
    public Employee(string name,int basic,int da,int hra)
    {
        this.id = employeeId++;
        this._name=name;
        this._basic = basic;
        this._da = da;  
        this._hra = hra;
                    
    }
    public virtual string Print()
    {
        return string.Format("name is {0},basic is {1}, da is {2}, hra is {3}", _name, _basic, _da, _hra);
    }
}
class Hr:Employee
{
    private int _hrallowance;
    public Hr(string name,int basic,int da,int hra,int allowance) :base(name,basic,da,hra)
    {
        this._hrallowance = allowance;
    }
    public override string Print()
    {
       return string.Format(base.Print()+"HR allowance is:"+_hrallowance);
    }

}
class Admin:Employee
{
    private int _adminallowance,totalsalary;
    public Admin(string name, int basic, int da, int hra,int allowance) : base(name, basic, da, hra)
    {
        this._adminallowance = allowance;
        totalsalary = basic + da + hra + allowance;
    }
    public override string Print()
    {
        return string.Format("{0}\n Admin Allowance is: {1}\n total salary is: {2}",base.Print(),_adminallowance,totalsalary);
    }

}
class Software:Employee
{
    private int _softwareallowance;
    public Software(string name, int basic, int da, int hra,int allowance) : base(name, basic, da, hra)
    {
        this._softwareallowance = allowance;
    }
    public override string Print()
    {
        return string.Format($"{base.Print()}\n Software allowance is {_softwareallowance}");
    }
}
class MainClass
{

    static void Main()
    {
        string name;
        char choice;
         int option,counter=0;
        int basic,da,hra,allowance;
        Employee[] employeearray = new Employee[3];
        do
        {
            Console.Write(" 1.HR\n 2.Admin\n 3.Software\n enter which employee to be added: ");
            option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the basic salary:");
            basic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Dearness Allowance");
            da = Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine("Enter the HRA");
            hra = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the Allowance for HR");
                     allowance = Convert.ToInt32(Console.ReadLine());
                    employeearray[counter++] = new Hr(name, basic, da, hra, allowance);
                    break;
                case 2:
                    Console.WriteLine("Enter the Allowance for Admin");
                    allowance = Convert.ToInt32(Console.ReadLine());
                    employeearray[counter++] = new Admin(name, basic, da, hra, allowance);
                    break;
                case 3:
                    Console.WriteLine("Enter the Allowance for Software");
                     allowance = Convert.ToInt32(Console.ReadLine());
                    employeearray[counter++] = new Software(name, basic, da, hra, allowance);
                    break;

            }
            Console.WriteLine("Do you want to continue:(Y/N)");
            choice = Console.ReadLine()[0];
        }while(choice == 'Y'||choice=='y');
        for (int i=0;i<counter;i++)
        {
            employeearray[i].Print();   
        }
        
            
    }
}