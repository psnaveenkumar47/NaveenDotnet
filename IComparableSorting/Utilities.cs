using System;
namespace IComparableSorting
{
    class utilities
    {
        public static void Sort<T>(T[] data)where T:IDoCompare
        {
            for(int i = 0;i < data.Length - 1;i++)
            {
                for(int j=i+1;j<data.Length;j++)
                {
                    if ((data[i].DoComparision(data[j]))>0)
                    {
                        T temp = data[i];
                        data[i] = data[j]; data[j] = temp;
                    }
                }
            }

        }
    }
}