using System;
namespace MulticlassInterface
{
    class Class1 : Interface2, Interface1
    {
        void Interface1.balance()
        {
            Console.WriteLine("balance amount is:");
        }

        internal void withdrawn()
        {
            Console.WriteLine("withdrawn amount");
        }
        
        internal void deposit()
        {
            Console.WriteLine("amount deposited ");
        }
        void Interface2.deposit()
        {
            Console.WriteLine("amount deposited I2");
        }

        void Interface2.withdrawn()
        {
            Console.WriteLine("withdrawn amount I2");
        }
    }
}