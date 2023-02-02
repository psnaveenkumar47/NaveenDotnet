class AverageResults
{
    static void Main()
    {
        int subject1, subject2, subject3, average;
        Console.Write("Enter the marks for C#: ");
        subject1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the marks for ASP.Net: ");
        subject2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the marks for SQL Server: ");
        subject3 = Convert.ToInt32(Console.ReadLine());
        average = (subject1 + subject2 + subject3) / 3;
        if (average <= 50)
        {
            Console.WriteLine($"Average is: {average}\nFailed");
        }
        else
        {
            Console.WriteLine($"Average is: {average}\nPassed");
        }
    }
}