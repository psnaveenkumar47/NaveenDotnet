class MainClass
{
    static void Main()
    {
        try
        {
            for(int i=0;i<5;i++)
            {
                i = 9;
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}