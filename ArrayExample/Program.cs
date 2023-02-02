using System;
class MainClass
{
    static void Main()
    {
        int size,average,sum=0,minimum,maximum;
        Console.Write("Enter size of an array :");
        size=Convert.ToInt32(Console.ReadLine());
        int[] array = new int[size];
        for(int i = 0; i < size; i++)
        {
            Console.Write("Enter element for {0} :",i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < size; i++)
        {
            sum+=array[i];
        }
        average=sum/size;
        minimum=array.Min();
        maximum=array.Max();
        Console.WriteLine("Average of Array Elements is: {0}",average);
        Console.WriteLine("Mininum of Array Elements is: {0}", minimum);
        Console.WriteLine("Maximum of Array Elements is: {0}", maximum);
        foreach(object o in array)
        {
            Console.WriteLine(o.ToString());
        }
    }
}