// Problem: Count and Print Vowels and Consonants in a String

// Question:
// Write a program to count and print the vowels and consonants in a given string.
// Vowels: a, e, i, o, u (both uppercase and lowercase)
// Consonants: all other alphabetic letters

// Input:
// A string entered by the user

// Output:
// Number of vowels and consonants
// Vowels and consonants themselves

// Example:
// Input: "Hello World"
// Output:
// Number of vowels: 3
// Vowels: e o o
// Number of consonants: 7
// Consonants: H l l W r l d

// Notes:
// - Ignore digits, spaces, and special characters
// - Preserve original case while printing

// Complexity:
// Time Complexity: O(n)  (each character checked once)
// Space Complexity: O(n)  (for storing vowels and consonants)

using System;
using System.Collections.Generic;

public class PrintVowelsConsonants
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        List<char> vowelsList = new List<char>();
        List<char> consonantsList = new List<char>();

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char ch = char.ToLower(c);
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    vowelsList.Add(c); // preserve case
                else
                    consonantsList.Add(c); // preserve case
            }
        }

        Console.WriteLine("Number of vowels: " + vowelsList.Count);
        Console.WriteLine("Vowels: " + string.Join(" ", vowelsList));

        Console.WriteLine("Number of consonants: " + consonantsList.Count);
        Console.WriteLine("Consonants: " + string.Join(" ", consonantsList));
    }
}
