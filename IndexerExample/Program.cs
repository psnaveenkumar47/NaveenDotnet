namespace Indexer
{
    class MainClass
    {
        static void Main()
        {
            Employee empobj= new Employee();
            empobj[0] = "naveen";
            empobj[1] = "maveen";
            empobj[2] = "raveen";
            empobj[3] = "sumit";
            empobj[4] = "hari";
            for(int i=0; i<Employee.size; i++)
            {
                Console.WriteLine(empobj[i]);
            }
            Console.WriteLine("------------------");
            empobj["naveen"] = 101;
            empobj["maveen"] = 102;
            empobj["raveen"] = 103;
            empobj["sumit"] = 104;
            empobj["hari"] = 105;
            for (int i = 0; i<Employee.size;i++)
            {
                Console.WriteLine(empobj[empobj[i]]);
            }

        }
    }
}