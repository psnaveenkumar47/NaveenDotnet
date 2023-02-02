using System;
using System.Collections;
namespace CollectionsExample
{
    class MainClass
    {
        static void Main()
        {
            Console.WriteLine("-------------HashTables-----------");
            HashTableExample.HashTab();
            Console.WriteLine("--------------SortedLists---------");
            SortedListsClass.SortList();
            Console.WriteLine("--------------HashSet-------------");
            HashSetClass.Hashsets();
            Console.WriteLine("--------------Queues--------------");
            QueueClass.QueueExample();
            Console.WriteLine("--------------Stacks--------------");
            StackClass.StackExample();
        }
    }
}