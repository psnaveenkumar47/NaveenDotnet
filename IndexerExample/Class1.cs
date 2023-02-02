using System;
namespace Indexer
{
    class Employee
    {
        string[] name = new string[size];
        int[] id = new int[size];
        public static int size = 5;
        public string this[int index]
        {
            get
            {
                if(index>=0 && index < size)
                {
                    return name[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if(index >= 0 && index < size)
                {
                    name[index] = value;
                }
            }
        }
        public int this [string Index]
        {
            get
            {
                for(int i=0;i<size;i++)
                {
                    if (name[i]==Index)
                    {
                        return id[i];
                    }
                }
                return 0;
            }
            set
            {
                for (int i = 0; i < size; i++)
                {
                    if (name[i] == Index)
                    {
                        id[i]=value;
                    }
                }
            }
            
        }

    }
}