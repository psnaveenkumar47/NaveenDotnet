using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    abstract class ClassOne : Interfacethree
    {
        public void MethodOne()
        {

        }
        public void MethodTwo()
        {

        }
    }
    class ClassTwo:ClassOne,InterfaceFour
    {
        public void MethodThree()
        {

        }
        public void MethodFour()
        {

        }
    }
    class MainClass
    {
        static void Main()
        {
            ClassTwo c2 = new ClassTwo();
            c2.MethodOne();
            c2.MethodTwo();
            c2.MethodThree();
            c2.MethodFour();
            ClassOne c1 = new ClassOne(); 
            c1.MethodOne();
            c1.MethodTwo();
        }
    }
}
