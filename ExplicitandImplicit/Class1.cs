using System;
namespace InterfaceExplanation
{
    class Class1: Interface2, Interface1
    {
      public void M()
        {
            Console.WriteLine("class1::M");
        }
        void Interface2.M()
        {
            Console.WriteLine("Interface2::M");
        }
       public void P()
        {
            Console.WriteLine("Class1::N");
        }
        void Interface1.N()
        {
            Console.WriteLine("Interface2::N");
        }
        public void N()
        {
            Console.WriteLine("Class1::N");
        }
        void Interface2.N()
        {
            Console.WriteLine("Interface1::N");
        }
    }
}