// Problem: Reverse a String without using built-in reverse functions

// Question:
// Write a program to reverse a string manually without using 
// built-in reverse methods or functions.

// Input:
// A string entered by the user

// Output:
// Reversed string

// Example:
// Input: "hello"
// Output: "olleh"

// Notes:
// Traverse the string from end to start and build the reversed string.

// Complexity:
// Time Complexity: O(n)  (each character visited once)
// Space Complexity: O(n)  (for storing the reversed string)

using System;

public class ReverseStringNaive
{
    public static void Main(string[] args)
    {
        Console.Write("Enter String: ");
        string input = Console.ReadLine();
        string rev = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            rev += input[i];
        }

        Console.WriteLine("Reversed String: " + rev);
    }
}
