using System;
using System.Text;

/// <summary>
/// Provides functionality to process words by removing common consonants and consecutive duplicates.
/// </summary>
public class Consonants
{
    /// <summary>
    /// Reads two words from input, removes common consonants, then removes consecutive duplicates, and prints the result.
    /// </summary>
    public static void Run()
    {
        string word1 = Console.ReadLine() ?? string.Empty;
        string word2 = Console.ReadLine() ?? string.Empty;

        string resultAfterTask1 = RemoveCommonConsonants(word1, word2); // Remove consonants in word1 that are also in word2
        string finalResult = RemoveConsecutiveDuplicates(resultAfterTask1); // Remove consecutive duplicate characters

        Console.WriteLine(finalResult);
    }

    /// <summary>
    /// Removes consonants from word1 that are also present in word2.
    /// </summary>
    /// <param name="word1">The first word to process.</param>
    /// <param name="word2">The second word to check for common consonants.</param>
    /// <returns>A string with common consonants removed from word1.</returns>
    private static string RemoveCommonConsonants(string word1, string word2)
    {
        StringBuilder result = new StringBuilder();

        string w1 = word1.ToLower();
        string w2 = word2.ToLower();

        foreach (char ch in w1)
        {
            // Skip the character if it is a consonant and also present in word2
            if (IsConsonant(ch) && w2.Contains(ch))
            {
                continue;
            }
            result.Append(ch);
        }

        return result.ToString();
    }

    /// <summary>
    /// Removes consecutive duplicate characters from the input string.
    /// </summary>
    /// <param name="input">The string to process.</param>
    /// <returns>A string with consecutive duplicates removed.</returns>
    private static string RemoveConsecutiveDuplicates(string input)
    {
        if (input.Length == 0)
            return input;

        StringBuilder result = new StringBuilder();
        result.Append(input[0]);

        for (int i = 1; i < input.Length; i++)
        {
            // Only append if the current character is different from the previous
            if (input[i] != input[i - 1])
            {
                result.Append(input[i]);
            }
        }

        return result.ToString();
    }

    /// <summary>
    /// Determines if a character is a consonant (i.e., a letter that is not a vowel).
    /// </summary>
    /// <param name="ch">The character to check.</param>
    /// <returns>True if the character is a consonant; otherwise, false.</returns>
    private static bool IsConsonant(char ch)
    {
        return char.IsLetter(ch) && !"aeiou".Contains(ch);
    }
}
