// Problem: Check if a String is Palindrome (Two-Pointer Approach)

// Question:
// Write a program to check whether a given string is a palindrome or not.
// A palindrome is a string that reads the same forwards and backwards.

// Input:
// A string entered by the user

// Output:
// "Palindrome String" if the input is palindrome
// "Not a Palindrome String" otherwise

// Example:
// Input: "madam"
// Output: Palindrome String
//
// Input: "hello"
// Output: Not a Palindrome String

// Notes:
// Use two pointers: one starting from the beginning and the other from the end,
// and compare characters while moving towards the center.

// Complexity:
// Time Complexity: O(n)  (each character compared at most once)
// Space Complexity: O(1) (only a few variables used)

using System;

public class PalindromeCheck
{
    public static void Main(string[] args)
    {
        Console.Write("Enter String: ");
        string input = Console.ReadLine();

        bool isPalindrome = true;
        int left = 0, right = input.Length - 1;

        while (left < right)
        {
            if (input[left] != input[right])
            {
                isPalindrome = false;
                break;
            }
            left++;
            right--;
        }

        if (isPalindrome)
            Console.WriteLine("Palindrome String");
        else
            Console.WriteLine("Not a Palindrome String");
    }
}
