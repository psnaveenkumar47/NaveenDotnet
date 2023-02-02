using System;
class Account
{
    static int accountnumber = 1000;
    public readonly int accountid;
     string _name;
     int _initialamount;

    public Account(string name,int intialamount)
    {
        this._name = name;
        this._initialamount = intialamount;
        accountid = accountnumber++;
    }



}
class MainClass
{
    static string name;
    static int counter, balance,intialamount,index;
    static char choice;
    static int depositamount, Withdrawamount;
    
    static Account[] Accountarray= new Account[10];
    static void Main()
    {
        int option;
        int Accountoption;
        Console.WriteLine("Select Option needed to perform\n1.Create Account\n2.Perform Operations\n3.Balance Enquiry\n4.Account Summary");
        option=Convert.ToInt32(Console.ReadLine());
        do
        {

            switch (option)
            {
                case 1:
                    AddAccount();
                    Accountarray[counter++] = new Account(name, intialamount);
                    break;
                case 2:
                    Console.WriteLine("Enter the Operation to Perform\n 1.Deposit\n2.Withdraw\n3.Balance Enquiry\n4.Previous Menu");
                    Accountoption = Convert.ToInt32(Console.ReadLine());
                    switch (Accountoption)
                    {
                        case 1:
                            Deposit();
                            break;
                        case 2:
                            Withdraw();
                            break;
                        case 3:
                            BalanceEnquiry();
                            break;
                        case 4:
                            break;
                    }
                    break;
                case 3:
                    BalanceEnquiry();
                    break;
                case 4:
                    AccountSummary();
                    break;
            }
            Console.WriteLine("Do you want to continue(Y|N)");
            choice = Console.ReadLine()[0];
        } while (choice == 'Y' || choice == 'y');
    }
        
    static void AddAccount()
    { 
        Console.WriteLine("Enter Name of an Account:");
        name = Console.ReadLine();
        Console.WriteLine("Enter Initial Amount For an Account "+name+": ");
        intialamount = Convert.ToInt32(Console.ReadLine());
    }
    static void Deposit()
    {
        Console.WriteLine("Enter amount to be Deposited");
        depositamount = Convert.ToInt32(Console.ReadLine());
        intialamount += depositamount;
        
    }
    static void Withdraw()
    {
        Console.WriteLine("Enter amount to Withdraw");
        Withdrawamount = Convert.ToInt32(Console.ReadLine());
        intialamount-= Withdrawamount;

    }
    static void BalanceEnquiry()
    {

    }
    static void AccountSummary()
    {

    }

}
