using System;
public delegate void PrintDelegate();

namespace DelegateUnderstanding
{
     class PrintingService
    {
        public static void Print(PrintDelegate d)
        {
            d();
        }
    }
}
