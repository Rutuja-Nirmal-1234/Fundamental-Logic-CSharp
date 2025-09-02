// Problem: Check if a String is Palindrome (Reverse and Compare)

// Question:
// Write a program to check whether a given string is a palindrome or not.
// A palindrome is a string that reads the same forwards and backwards.

// Input:
// A string entered by the user

// Output:
// "Palindrome String" if the input is palindrome
// "Not a Palindrome String" otherwise

// Example:
// Input: "racecar"
// Output: Palindrome String
//
// Input: "world"
// Output: Not a Palindrome String

// Notes:
// Reverse the string manually (or using built-in methods) 
// and then compare it with the original string.

// Complexity:
// Time Complexity: O(n)  (string reversed once, then comparison)
// Space Complexity: O(n)  (extra storage for the reversed string)

using System;

public class PalindromeCheckByReverse
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
