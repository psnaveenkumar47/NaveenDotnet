using System;
using System.Collections;
namespace OptionalAndNamedParameters
{
    class MainClass
    {
        public static void M(string name,bool b=false,ArrayList mylist=null)
        {
            Console.WriteLine(name + " ");
            Console.WriteLine(b);
        }
        static void Main()
        {
            M("naveen", true);
            M("mindtree",true,new ArrayList());
            M("naveen",mylist: new ArrayList());
        }
    }
}