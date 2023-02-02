using System;
namespace DisposeDemo
{
    class class1 : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Run cleanup code here");
        }
        ~class1()
        {
            Console.WriteLine("destructor for cleanup code");
        }
    }
    class MainClass
    {
        static void Main()
        {
            class1[] c = new class1[10];
            for (int i = 0; i < 10; i++)
            {
                using (c[i] = new class1())
                {

                }
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("---------------------------------");
        }
    }
}