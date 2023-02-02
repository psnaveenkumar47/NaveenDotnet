using System;
namespace InterfaceExplanation
{
    class MainClass
    {
        static void Main()
        {
            Class1 c1=new Class1();
            c1.M();
            c1.P();
            Interface2 i1 = c1;
            i1.M();
            Interface1 i2 = c1;
            i2 = i1;
            i2.N();
           
        }
    }
}