// Problem: Factorial of a Number (Loop Method)

// Question:
// Write a program to compute the factorial of a given number using a loop.
// The factorial of n (denoted as n!) is defined as:
// n! = n × (n-1) × (n-2) × ... × 1
// Special case: 0! = 1

// Input:
// A single integer n (>= 0)

// Output:
// The factorial value of n

// Example:
// Input: 5
// Output: 120
// Explanation: 5! = 5 × 4 × 3 × 2 × 1 = 120

// Notes:
// Loop through numbers from 1 to n and multiply sequentially.

// Complexity:
// Time Complexity: O(n)  (single loop from 1 to n)
// Space Complexity: O(1) (constant extra space)

using System;

public class FactorialLoop
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
            return;
        }

        long fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }

        Console.WriteLine("Factorial of " + n + " is: " + fact);
    }
}
