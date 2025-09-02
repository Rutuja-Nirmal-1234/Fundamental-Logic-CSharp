// Problem: Reverse a String using Built-in Function

// Question:
// Write a program to reverse a string using built-in methods 
// (Array.Reverse in this case).

// Input:
// A string entered by the user

// Output:
// Reversed string

// Example:
// Input: "chatgpt"
// Output: "tpgta hc"

// Notes:
// Convert the string into a character array, use Array.Reverse() to reverse in-place,
// and then construct a new string from the reversed array.

// Complexity:
// Time Complexity: O(n)  (Array.Reverse runs in linear time)
// Space Complexity: O(n)  (char array + new string construction)

using System;

public class ReverseStringBuiltIn
{
    public static void Main(string[] args)
    {
        Console.Write("Enter String: ");
        string input = Console.ReadLine();

        char[] arr = input.ToCharArray();
        Array.Reverse(arr);

        string reversed = new string(arr);
        Console.WriteLine("Reversed String: " + reversed);
    }
}
