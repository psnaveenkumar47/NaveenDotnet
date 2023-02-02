using System;
class Bank
{
     int accountnumber;
    public readonly int accountid;
    string _name;
    int _initialamount,_balance;

    public Bank(int number,string name, int intialamount,int balance)
    {
        this._name = name;
        this._initialamount = intialamount;
        this.accountnumber=number;
        this._balance = balance;    
    }
    public  string AccountSummary()
    {
        return String.Format($"{accountnumber} {_name} {_initialamount} {_balance}");
    }



}
class MainClass
{
    static string nameofdepositor,typeofaccount;
    static int balance, intialamount,accountnumber;
    static char choice;
    static int depositamount, option;
    static Bank b1;
    static void Main()
    {
        int option;
        int Accountoption;
        do
        {
            Console.Write("1.Add Account\n2.Deposit Amount\n3.Account Summary\nEnter option to continue: ");
            option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1: AddAccount();
                    break;
                case 2: DepositAmount();
                    break;
                case 3:AccountSummary();
                    break;
            }
            Console.WriteLine("Do you want to continue(Y|N)");
            choice = Console.ReadLine()[0];
        } while (choice == 'Y' || choice == 'y');
    }

    static void AddAccount()
    {
        Console.Write("Enter Name of an Depositor:");
        nameofdepositor = Console.ReadLine();
        Console.Write("Enter Account Number:");
        accountnumber = Convert.ToInt32(Console.ReadLine());
        InitialAmount();
    }
    static void InitialAmount()
    {
        Console.WriteLine("Enter Initial Amount For an Account " + nameofdepositor + ": ");
        intialamount = Convert.ToInt32(Console.ReadLine());
    }
    static void DepositAmount()
    {
        Console.WriteLine("Enter amount to be Deposited");
        depositamount = Convert.ToInt32(Console.ReadLine());
        intialamount += depositamount;

    }   
    static void AccountSummary()
    {
        b1 = new Bank(accountnumber,nameofdepositor,intialamount,balance);
    }

}
