using System;

class Account
{
    public int AccountNumber = 1;

    protected virtual void number(int number)
    {
        this.AccountNumber = number;

        Console.WriteLine("Account number is: " + AccountNumber);
    }
}
class Student : Account
{
    public new void number()
    {
        int Newnumber;
        Account account1 = new Student();
        Console.WriteLine("Enter Id");
        Newnumber = Convert.ToInt32(Console.ReadLine());
        this.number(Newnumber);
    }

}
class MainClass
{
    static void Main()
    {
        Account account = new Account();
        Student student = new Student();
        student.number();



    }
}