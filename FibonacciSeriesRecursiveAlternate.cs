// Problem: Print Fibonacci Series up to N Terms (Recursive Alternate Method)

// Question:
// Write a program to print the Fibonacci series up to 'n' terms using recursion.
// Instead of calculating each Fibonacci number separately, use a recursive 
// function that directly prints the series in sequence.

// Input:
// An integer n (number of terms to print)

// Output:
// The Fibonacci series up to n terms

// Example:
// Input: n = 7
// Output: 0 1 1 2 3 5 8

// Notes:
// This approach uses recursion with parameters to print values as we go.
// It avoids recalculating the same Fibonacci numbers multiple times.

// Complexity:
// Time Complexity: O(n)  (each term is printed once)
// Space Complexity: O(n)  (due to recursion call stack)

using System;

public class FibonacciSeriesRecursiveAlternate
{
    static void PrintFibonacci(int a, int b, int n)
    {
        if (n == 0)
            return;

        Console.Write(a + " ");
        PrintFibonacci(b, a + b, n - 1);
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        Console.WriteLine("Fibonacci Series:");
        PrintFibonacci(0, 1, n);
    }
}
