using System;
using System.Collections;

namespace UnderstandingCollections
{
   class IenumExample
    {
        public static void Ienum()
        {
            int[] array={ 1,2,3,4,5};
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
            IEnumerable en = array;
            IEnumerator enumerator = en.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.ToString());
            }

        }
    }
}
