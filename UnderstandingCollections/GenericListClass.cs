using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingCollections
{
   class GenericListClass
    {
       public static void Generic()
        {
            List<int> list = new List<int>(3);
            list.Add(2);
            list.Add(3);
            list.Add(4);  
            list.Add(5);
            list.Remove(2);
            foreach (object o in list)
            {
                Console.WriteLine(o);
            }
        }
    }
}
