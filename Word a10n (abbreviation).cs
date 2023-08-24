using System;
using System.Text;
using System.Text.RegularExpressions;

public class Abbreviator
{
    public static string Abbreviate(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        StringBuilder result = new StringBuilder();
        string[] words = Regex.Split(input, @"(\W+)");

        foreach (string word in words)
        {
            if (word.Length > 3)
            {
                int innerWordLength = word.Length - 2;
                result.Append(word[0]);
                result.Append(innerWordLength);
                result.Append(word[word.Length - 1]);
            }
            else
            {
                result.Append(word);
            }
        }

        return result.ToString();
    }
}