// Problem: Generate Fibonacci Series (Recursive Method)

// Question:
// Write a program to generate the Fibonacci series up to 'n' terms 
// using recursion. The Fibonacci series starts with 0 and 1, and each 
// subsequent term is the sum of the two preceding terms.

// Input:
// An integer n (number of terms to generate)

// Output:
// The Fibonacci series up to n terms

// Example:
// Input: n = 7
// Output: 0 1 1 2 3 5 8

// Notes:
// This approach uses recursion to calculate each Fibonacci number.
// ⚠️ Less efficient than iterative solution due to repeated calculations.

// Complexity:
// Time Complexity: O(2^n)  (exponential, due to repeated calls)
// Space Complexity: O(n)   (recursion call stack)

using System;

public class FibonacciSeriesRecursive
{
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
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

        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }
}
