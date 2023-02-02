class MainClass
{
    static void Main()
    {
        int number;
        Console.WriteLine("Enter the number");
        number = Convert.ToInt32(Console.ReadLine());
        if(number%2==0)
        {
            Console.WriteLine($"{number} is a Even Number");
        }
        else
        {
            Console.WriteLine($"{number} is a Odd Number");

        }
    }
}