class StringPalindrome
{
    static void Main()
    {
        string word,reverse=string.Empty;
        Console.Write("Enter a word to find Palindrome are Not: ");
        word=Console.ReadLine();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse = reverse + word[i].ToString();
            }
            if (reverse == word)
            {
                Console.WriteLine("Given string is Palindrome");
            }
            else
            {
                Console.WriteLine("Given string is Not Palindrome");
            }
        
    }
}