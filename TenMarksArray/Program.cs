using System;
class MainClass
{
    static void Main()
    {
        int total=0,minimum,maximum,average,ascending;
        int[] marksarray = new int[10];
        for (int i = 0; i < marksarray.Length; i++)
        {
            Console.Write($"Enter the marks for subject {i+1}:");
            marksarray[i] = Convert.ToInt32(Console.ReadLine());
            total+=marksarray[i];
        }
        average = total/10;
        Array.Sort(marksarray);
        Console.WriteLine($"\nTotal marks for 10 Subjects is: {total}");
        Console.WriteLine($"Average marks for 10 Subjects is: {average}");
        Console.WriteLine($"Minimum marks for 10 Subjects is: {marksarray.Min()}");
        Console.WriteLine($"Maximum marks for 10 Subjects is: {marksarray.Max()}");
        Console.Write($"Ascending order marks for 10 Subjects is: ");
        for (int i = 0; i < marksarray.Length; i++)
        {
            Console.Write($" {marksarray[i]}");
        }
        Array.Reverse(marksarray);
        Console.Write($"\ndescending order marks for 10 Subjects is: ");
        for (int i = 0; i < marksarray.Length; i++)
        {
          Console.Write($" {marksarray[i]}");
        }
    }
}