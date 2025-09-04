// Problem: Count Vowels and Consonants in a String

// Question:
// Write a program to count the number of vowels and consonants in a given string.
// Vowels: a, e, i, o, u (both uppercase and lowercase)
// Consonants: all other alphabetic letters

// Input:
// A string entered by the user

// Output:
// Number of vowels and consonants

// Example:
// Input: "Hello World"
// Output:
// Vowels: 3
// Consonants: 7

// Notes:
// - Ignore spaces, digits, and special characters
// - Traverse the string and check each character

// Complexity:
// Time Complexity: O(n)  (each character checked once)
// Space Complexity: O(1) (constant extra space)

using System;

public class CountVowelsConsonants
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int vowels = 0, consonants = 0;

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char ch = char.ToLower(c);
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    vowels++;
                else
                    consonants++;
            }
        }

        Console.WriteLine("Vowels: " + vowels);
        Console.WriteLine("Consonants: " + consonants);
    }
}
