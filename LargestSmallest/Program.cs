class LargestSmallest
{
    static void Main()
    {
        int a,b, c;
        Console.WriteLine("Enter three numbers to compare");
        Console.Write("Enter first number:");
        a=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number:");
        c = Convert.ToInt32(Console.ReadLine());
        if(a>b&&a>c)
        {
            Console.WriteLine($"{a} is greater ");
        }
        else if(b>c)
        {
            Console.WriteLine($"{b} is greater");
        }
        else
        {
            Console.WriteLine($"{c} is greater");
        }
        if (a < b && a < c)
        {
            Console.WriteLine($"{a} is smaller ");
        }
        else if (b < c)
        {
            Console.WriteLine($"{b} is smaller");
        }
        else
        {
            Console.WriteLine($"{c} is smaller");
        }
    }
}