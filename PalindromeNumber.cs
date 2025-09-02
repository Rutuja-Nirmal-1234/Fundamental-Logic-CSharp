// Problem: Check if a Number is Palindrome

// Question:
// Write a program to check whether a given integer is a palindrome or not.
// A palindrome number reads the same forwards and backwards.

// Input:
// An integer entered by the user

// Output:
// "Palindrome Number" if the number is palindrome
// "Not a Palindrome Number" otherwise

// Example:
// Input: 121
// Output: Palindrome Number
//
// Input: 123
// Output: Not a Palindrome Number

// Notes:
// Reverse the digits of the number and compare it with the original number.

// Complexity:
// Time Complexity: O(d)  (where d = number of digits)
// Space Complexity: O(1) (only a few variables used)

using System;

public class PalindromeNumber
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int original = num;
        int reversed = 0;

        while (num > 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }

        if (original == reversed)
            Console.WriteLine("Palindrome Number");
        else
            Console.WriteLine("Not a Palindrome Number");
    }
}
