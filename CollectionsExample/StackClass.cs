using System;
using System.Collections;

namespace CollectionsExample
{
    internal class StackClass
    {
        public static void StackExample()
        {
            Stack<int> stackarray = new Stack<int>();
            stackarray.Push(1);
            stackarray.Push(2);
            stackarray.Push(3);
            stackarray.Push(4);
            stackarray.Pop();
            stackarray.Peek();
            foreach (int i in stackarray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(stackarray.Count);
            Console.WriteLine(stackarray.Contains(1));
        }
    }
}
