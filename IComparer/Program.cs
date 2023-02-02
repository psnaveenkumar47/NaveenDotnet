using System;
using System.Collections;

public class MainClass
{
    
        public int Compare(Object x, Object y);
     
    public static void Main()
    {
        int[] numbers = {34,64,65,23,54,99,1};
        Console.WriteLine("The array initially contains the following values:");
        PrintingValues(numbers);
        Array.Sort(numbers);
        Console.WriteLine("After sorting with the default comparer:");
        PrintingValues(numbers);
        Array.Sort(numbers,C    ompare());
        Console.WriteLine("After sorting with the reverse  comparer:");
        PrintingValues(numbers);
    }

    public static void PrintingValues(IEnumerable list)
    {
        int i = 0;
        foreach (int j in list)
            Console.WriteLine($"   [{i++}]:  {j}");

        Console.WriteLine();
    }
}