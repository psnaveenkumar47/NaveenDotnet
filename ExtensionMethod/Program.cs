public static class MyExtensions
{
    public static int ToIntConvert(this String s)
    {
        return int.Parse(s);
    }
}
class MainClass
{
    static void Main()
    {
        string str = "124545";
        int i=str.ToIntConvert();
        Console.WriteLine(i);
    }
}