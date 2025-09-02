// Problem: Receive Array Elements from User & Display

// Question:
// Write a program to take the size of an array from the user,
// then input each element, and finally display all elements of the array.

// Input:
// First line: integer `n` (size of array)
// Next n lines: array elements entered by user

// Output:
// Display the array elements in the same order as entered

// Example:
// Input: n = 5, arr = [10, 20, 30, 40, 50]
// Output: 10 20 30 40 50

// Notes:
// Uses a loop to take input and a foreach loop to display elements.

// Complexity:
// Time Complexity: O(n)  (input + display each element once)
// Space Complexity: O(n)  (to store the array)

using System;

public class ReceiveArrayElements
{
    public static void Main(string[] args)
    {
        Console.Write("Enter size of array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter {i + 1} element: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Array Elements are:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
