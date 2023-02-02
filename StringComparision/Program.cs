class MainClass
{
    static void Main()
    {
        string firstword, secondword;
        Console.Write("Enter First Word: ");
        firstword=Console.ReadLine();
        Console.Write("Enter Second Word: ");
        secondword=Console.ReadLine();
        if(firstword==secondword)
        {
            Console.WriteLine($"{firstword} : {secondword} =  Same");
        }
        else
        {
            Console.WriteLine($"{firstword} : {secondword} =  Not Same");
        }
    }
}