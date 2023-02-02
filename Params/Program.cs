using System;
namespace Params
{
    class MainClass
    {
        static void M(int i,string s,params byte []j )
        {
            foreach(byte b in j)
            {
                Console.WriteLine(b+" ");
            }
            Console.WriteLine();
        }
        static void N(params int []k)
        {

        }
        static void S(params string []s)
        {

        }
        static void Main()
        {
            byte[] b = { 10, 20, 30, 40 };
            M(10, "maveen", b);
            M(4, "naveen", 23, 34, 56, 9, 3, 67, 54);

        }
    }
}