// Problem: Check if a String is Palindrome (Method 2 – Reverse & Compare)

// Question:
// Write a program to check whether a given string is a palindrome or not.
// A palindrome is a word, phrase, or sequence that reads the same 
// backward as forward (e.g., "madam", "racecar").

// Approach (Method 2):
// Reverse the string and compare it with the original string.

// Input:
// A string from the user

// Output:
// "Palindrome String" if input is palindrome
// "Not a Palindrome String" otherwise

// Example:
// Input: "madam"
// Output: Palindrome String
//
// Input: "hello"
// Output: Not a Palindrome String

// Complexity:
// Time Complexity: O(n)  (string reversal takes linear time)
// Space Complexity: O(n) (extra array used for reversal)

using System;

public class PalindromeCheckReverse
{
    public static void Main(string[] args)
    {
        Console.Write("Enter String: ");
        string input = Console.ReadLine();

        char[] arr = input.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        if (input == reversed)
            Console.WriteLine("Palindrome String");
        else
            Console.WriteLine("Not a Palindrome String");
    }
}
