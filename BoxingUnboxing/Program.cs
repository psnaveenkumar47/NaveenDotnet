using System;
namespace BoxingUnboxing
{
    class MainClass
    {
        static void Main()
        {
            byte b;
            b = Convert.ToByte(Console.ReadLine());
            object obj = b;           
            Console.WriteLine(obj);
            b++;
            Console.WriteLine(b);
            b = 6;
            obj = 7;
            Console.WriteLine(obj);
            Console.WriteLine(b);
            int j = (int)obj;
            Console.WriteLine(j);

        }
    }
}