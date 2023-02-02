class MailClass
{
    static void Main()
    {
        string word;
        Console.Write("Enter a Word : ");
        word=Console.ReadLine();
        StringLength(word);
        StringReverse(word);
    }
    static void StringLength(string word)
    {
        Console.WriteLine($"Length of given word {word} is:{word.Length}");
    }
    static void StringReverse(String word)
    {
        char[] chars = word.ToCharArray();
        Console.Write($"Reverse of given word {word} is:");
        for (int i = chars.Length-1; i >= 0; i--)
        {
            Console.Write($"{chars[i]}");
        }
    }
}