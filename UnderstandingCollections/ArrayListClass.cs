using System;
using System.Collections;


namespace UnderstandingCollections
{
     class ArrayListClass
    {
        public static void Arrays()
        {
            ArrayList a1 = new ArrayList(3);
            a1.Add("PS");
            a1.Add(45);
            ArrayList arraylist = new ArrayList(3);
            arraylist.Add(1);
            //arraylist[0] = 2;
            arraylist.Add("naveen");
            //arraylist[1] = 3;
            arraylist.Add(234);
            arraylist.Add("kumar");
            arraylist.Add(4);
            arraylist.Remove("kumar");
            arraylist.Add(new Queue());
            arraylist.Add(new MainClass());
            arraylist.Add(a1[0]);
            foreach (object i in arraylist)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(arraylist.Count);
            Console.WriteLine(arraylist.Capacity);
        }
    }
}
