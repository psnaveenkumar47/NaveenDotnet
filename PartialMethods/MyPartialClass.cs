using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethods
{
     class MyPartialClass
    {
        partial void M()
        {
            Console.WriteLine("partial Methods M");
           
        }
        static partial void N()
        {
            Console.WriteLine("static partial Method implemented");
        }
        public static void CallStaticMethod()
        {
            N();
        }
        public void CallNonStaticMethod()
        {
            this.M();   
        }
    }
}
