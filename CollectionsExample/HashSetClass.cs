using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExample
{
    internal class HashSetClass
    {
        public static void Hashsets()
        {
            string[] array1 = { "pen", "pencil", "paper", "pen", "table", "spects" };
            HashSet<string> array2 = new HashSet<string>(array1);
            foreach(string s in array2)
            {
                Console.WriteLine(s);   
            }
        }
    }
}
