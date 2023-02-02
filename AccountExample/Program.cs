using System;
class Accounts
{
    static int Accountnumber = 101;
    int _balance,_id,amount;
     string name;
     char type;
  public Accounts(string customername, char accounttype,int amount, int balance)
    {
        this._id = Accountnumber++;
        this.name = customername;
        this.type = accounttype;
        this._balance=balance;
        this.amount = amount;

    }
    public string PrintSummary()
    {
        return String.Format($"Customer Name: {name}\nTransaction Type: {type}\nAmount : {amount}\nBalance is: {_balance} ");
    }

}
class MainClass
{
   // static int accountnumber;
    static string customername;
    static int amount, balance=0;
    static char choice, transactiontype;
    static Accounts[] accountarray = new Accounts[10];
    static void Main()
    {
        do
        {
            Console.Write("Enter the Transaction type :");
            transactiontype = Console.ReadLine()[0];
            if (transactiontype == 'D' || transactiontype == 'd')
            {
                Console.Write("Enter amount to be Deposited: ");
                amount = Convert.ToInt32(Console.ReadLine());
                credit(amount);
            }
            else if (transactiontype == 'W' || transactiontype == 'w')
            {
                Console.Write("Enter amount to be Withdrawn: ");
                amount = Convert.ToInt32(Console.ReadLine());
                debit(amount);
            }
            Console.Write("Do you want to Continue (y/n):");
            choice = Console.ReadLine()[0];
        } while (choice == 'y' || choice == 'Y');
    }
    static void credit(int amount)
    {
        balance = + amount;
        accountarray[0] = new Accounts("naveen", choice, amount,balance);
        Console.WriteLine(accountarray[0].PrintSummary());
        
    }
    static void debit(int amount)
    {
        balance -= amount;
        //accountarray[0] = new Accounts("naveen", choice,amount, balance);
        Console.WriteLine(accountarray[0].PrintSummary());            

    }
}