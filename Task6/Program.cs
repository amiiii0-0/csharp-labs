
using System;

class Program
{
    static void Main()
    {
        string text;

        do
        {
            Console.Write("Enter your text: ");
            text = Console.ReadLine() ?? "";
        }
        while (text.Length == 0);

        int count;
        string result = ConvertText(text, out count);

        Console.WriteLine("Original text: " + text);
        Console.WriteLine("Uppercase letters: " + count);
        Console.WriteLine("Result: " + result);
    }

    static string ConvertText(string text, out int count)
    {
        count = 0;
        string result = "";

        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];

            if (char.IsUpper(ch))
            {
                count++;
                ch = char.ToLower(ch);
            }

            result += ch;
        }

        return result;
    }
}

