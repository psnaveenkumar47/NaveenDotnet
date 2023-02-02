using System;
using System.Collections;


namespace CollectionsExample
{
    class SortedListsClass
    {
        public static void SortList()
        {
           SortedList slists=new SortedList();
            slists.Add("a1","naveen");
            slists.Add("e1","mukesh");
            slists.Add("z1","abhinaya");
            slists.Add("f1","sumit");
            slists.Add("b1","hari");
            ICollection c = slists.Values;

            foreach(object o in slists.Values)
            {
                Console.WriteLine(o);
            }
            
            Console.WriteLine($"{slists.GetByIndex(0)} is at index position 1");

        }
    }
}
