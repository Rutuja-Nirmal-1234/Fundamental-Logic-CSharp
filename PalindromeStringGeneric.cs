// Problem: Check if a String is Palindrome (Generic)

// Question:
// Write a program to check whether a given string is a palindrome or not.
// The check should ignore case and non-alphanumeric characters 
// (spaces, punctuation, symbols).

// Input:
// A string entered by the user

// Output:
// "Palindrome String" if the input is palindrome
// "Not a Palindrome String" otherwise

// Example:
// Input: "A man, a plan, a canal: Panama"
// Output: Palindrome String
//
// Input: "Hello, World!"
// Output: Not a Palindrome String

// Notes:
// - Convert string to lowercase
// - Remove non-alphanumeric characters
// - Use two-pointer technique to compare characters

// Complexity:
// Time Complexity: O(n)  (each character checked at most once)
// Space Complexity: O(n)  (for the filtered string)

using System;

public class PalindromeStringGeneric
{
    public static void Main(string[] args)
    {
        Console.Write("Enter String: ");
        string input = Console.ReadLine();

        // Normalize string: lowercase + remove non-alphanumeric
        string cleaned = "";
        foreach (char c in input.ToLower())
        {
            if (char.IsLetterOrDigit(c))
                cleaned += c;
        }

        // Two-pointer palindrome check
        int left = 0, right = cleaned.Length - 1;
        bool isPalindrome = true;

        while (left < right)
        {
            if (cleaned[left] != cleaned[right])
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
