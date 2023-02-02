using System;
using System.Collections;

namespace CollectionsExample
{
    public class HashTableExample
    {
       public static void HashTab   ()
        {
            Hashtable htable = new Hashtable();
            htable.Add(1, "naveen");
            htable.Add(2, "sumit");
            htable.Add(3, "rajini");
            htable.Add(4, "mukesh");
            htable.Add(5, "abinaya");
            htable.Add(6, "hari");
            foreach(object o in htable.Values)
            {
                Console.WriteLine(o);
            }
            foreach(int i in htable.Keys)   
            {
                Console.WriteLine(i);
            }
        }


    }
}
