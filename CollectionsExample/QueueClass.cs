using System;
using System.Collections;

namespace CollectionsExample
{
    internal class QueueClass
    {
        public static void QueueExample()
        {
            Queue<string> queuearray = new Queue<string>();
            queuearray.Enqueue("naveen");
            queuearray.Enqueue("mukesh");
            queuearray.Enqueue("abhinaya");
            queuearray.Dequeue();            
            foreach (var item in queuearray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(queuearray.Contains("mukesh"));
        }
    }
}
