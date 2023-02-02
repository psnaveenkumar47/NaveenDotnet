using System.Collections;

class MainClass
{
    public static IEnumerable GetAllUsers()
    {
        yield return 1;
        yield return 2;
        yield return 3;
    }
    static void Main()
    {
        foreach(int i in GetAllUsers())
        {
            Console.WriteLine(i);
        }
        string name = "mindtree";
        IEnumerable e = name;
        IEnumerable en = e.GetEnumerator();
        while(en.MoveNext())
        {
            Console.WriteLine(en.Current);
        }
        foreach(char c in name)
        {
            Console.WriteLine(c);
        }

    }
}