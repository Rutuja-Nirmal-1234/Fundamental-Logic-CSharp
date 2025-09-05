// Problem: Count the number of even and odd numbers in a list

// Question:
// Write a program that reads a list of integers from the user
// and counts how many numbers are even and how many are odd.

// Input:
// - Size of list (n)
// - n integers (list elements)

// Output:
// - Count of even numbers
// - Count of odd numbers

// Example:
// Input: n = 5, arr = [1, 2, 3, 4, 5]
// Output:
// Count of even numbers: 2
// Count of odd numbers: 3

// Complexity:
// Time Complexity: O(n)   (single pass through the list)
// Space Complexity: O(1)  (only counters used)

using System;
using System.Collections.Generic;

public class CountEvenOdd
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        List<int> numbers = new List<int>();
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            numbers.Add(Convert.ToInt32(Console.ReadLine()));
        }

        int evenCount = 0, oddCount = 0;

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        Console.WriteLine("Count of even numbers: " + evenCount);
        Console.WriteLine("Count of odd numbers: " + oddCount);
    }
}
