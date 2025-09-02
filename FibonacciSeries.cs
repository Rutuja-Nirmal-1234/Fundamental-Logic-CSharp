// Problem: Generate Fibonacci Series (Loop Method)

// Question:
// Write a program to generate the Fibonacci series up to 'n' terms.
// The Fibonacci series starts with 0 and 1, and each subsequent term
// is the sum of the two preceding terms.

// Input:
// An integer n (number of terms to generate)

// Output:
// The Fibonacci series up to n terms

// Example:
// Input: n = 7
// Output: 0 1 1 2 3 5 8

// Notes:
// Use iteration (loop method) to generate terms.

// Complexity:
// Time Complexity: O(n)  (each term calculated once)
// Space Complexity: O(1) (only a few variables used)

using System;

public class FibonacciSeries
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        int first = 0, second = 1;

        Console.WriteLine("Fibonacci Series:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(first + " ");
            int next = first + second;
            first = second;
            second = next;
        }
    }
}
