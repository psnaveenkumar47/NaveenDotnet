namespace Test
{
    delegate void CallFunctionDelegate(int i);
    class MainClass
    {
        static void Main()
            {
            int i = 10;
            CallFunctionDelegate c = delegate (ref int x)
            {
                i = 30;
                x = 20;

            };
            c(ref i);
            Console.Write(i);
            Console.Write(x);
        }
    }
}