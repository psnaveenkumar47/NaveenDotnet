using System;
/*
public class MyException : Exception
{
    public MyException:base() { }
    public MyException(string message):base(message){ }

}
*/

class MainClass
{
    static int balance;
   

    static void Main()
    {
        int option;
        char choice;
        do
        {
            Console.WriteLine("Enter the operation to perform\n1.Deposit\n2.Withdraw\n3.Balance");
        option = Convert.ToInt32(Console.ReadLine());         
        switch(option)
        {
            case 1:Deposit();
                break;
            case 2:
                try
                {
                    Withdraw();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                break;
            case 3:
                break;
        }
            Console.WriteLine("Do you want to continue(y/n)");
            choice = Console.ReadLine()[0];
        } while (choice=='y'||choice=='Y');

    }
    public static void Deposit()
    {
        int amount;
        Console.WriteLine("Enter amount to deposit");
        amount = Convert.ToInt32(Console.ReadLine());
        balance+=amount;
    
    }
    public static void Withdraw()
    {
        int amount;
        Console.WriteLine("Enter amount to withdraw");
        amount=Convert.ToInt32(Console.ReadLine());
        if (balance > amount)
        {
            balance -= amount;
            Console.WriteLine("Balance amount",balance);
        }
        else
        {
            throw new Exception("Out of Funds Excception");
        }
    }
    public void Balance()
    {

    }
}