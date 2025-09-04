// Problem: Count Vowels in a String

// Question:
// Write a program to count the number of vowels in a given string.
// Vowels are: a, e, i, o, u (both uppercase and lowercase).

// Input:
// A string entered by the user

// Output:
// Number of vowels in the string

// Example:
// Input: "Hello World"
// Output: 3
// Explanation: 'e', 'o', 'o' are vowels

// Notes:
// Traverse the string and check each character against vowels.

// Complexity:
// Time Complexity: O(n)  (each character checked once)
// Space Complexity: O(1) (constant extra space)

using System;

public class CountVowels
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int count = 0;
        foreach (char c in input)
        {
            char ch = char.ToLower(c);
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                count++;
            }
        }

        Console.WriteLine("Number of vowels: " + count);
    }
}
