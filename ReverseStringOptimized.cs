// Problem: Reverse a String using Two-Pointer Approach (Optimized)

// Question:
// Write a program to reverse a string manually using the two-pointer method
// (without using built-in reverse functions).

// Input:
// A string entered by the user

// Output:
// Reversed string

// Example:
// Input: "world"
// Output: "dlrow"

// Notes:
// Optimized Approach: Convert the string to a char array, then swap characters 
// from both ends moving towards the center (two-pointer technique).
// Finally, build a new string from the modified char array.

// Complexity:
// Time Complexity: O(n)  (each character is swapped at most once)
// Space Complexity: O(1)  (in-place swaps; only final string construction)

using System;

public class ReverseStringOptimized
{
    public static void Main(string[] args)
    {
        Console.Write("Enter String: ");
        string input = Console.ReadLine();

        char[] arr = input.ToCharArray();
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            char temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            left++;
            right--;
        }

        string reversed = new string(arr);
        Console.WriteLine("Reversed String: " + reversed);
    }
}
