using System;
class MainClass
{
    static void Main()
    {
        int choice;
        Console.WriteLine("1.Swap numbers\n2.swap String\n");
        choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:int a, b;
                Console.WriteLine("Enter first number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                b = Convert.ToInt32(Console.ReadLine());
                SwapNumber(a,b);
                break;
            case 2:string s1, s2;
                Console.WriteLine("Enter first string");
                s1 = Console.ReadLine();
                Console.WriteLine("Enter second string");
                s2 = Console.ReadLine();
                SwapString(s1,s2);
                break;
        }
        static void SwapNumber(int a, int b)
        {
            int  t;           
            Console.WriteLine($"Number before Swap is :{a}  {b}");
            t = a;
            a = b;
            b = t;
            Console.WriteLine($"Number after Swap is :{a}  {b}");

        }
        static void SwapString(string s1,string s2)
        {
            string t;
            Console.WriteLine($"Number before Swap is :{s1}  {s2}");
            t = s1;
            s1 = s2;
            s2 = t;
            Console.WriteLine($"Number after Swap is :{s1}  {s2}");
        }
    }
}