// Problem: Count and Print Vowels in a String

// Question:
// Write a program to count the number of vowels in a given string
// and also print all the vowels found.
// Vowels are: a, e, i, o, u (both uppercase and lowercase).

// Input:
// A string entered by the user

// Output:
// Number of vowels and the vowels themselves

// Example:
// Input: "Hello World"
// Output: 
// Number of vowels: 3
// Vowels: e o o

// Notes:
// Traverse the string, check each character against vowels, 
// and store found vowels for printing.

// Complexity:
// Time Complexity: O(n)  (each character checked once)
// Space Complexity: O(n)  (for storing vowels found)

using System;
using System.Collections.Generic;

public class CountAndPrintVowels
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        List<char> vowelsFound = new List<char>();

        foreach (char c in input)
        {
            char ch = char.ToLower(c);
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                vowelsFound.Add(c); // store original character (case preserved)
            }
        }

        Console.WriteLine("Number of vowels: " + vowelsFound.Count);
        Console.WriteLine("Vowels: " + string.Join(" ", vowelsFound));
    }
}
