// Problem: Factorial of a Number (Recursive Approach)

// Question:
// Write a program to compute the factorial of a given number using recursion.
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
// Recursive definition:
// factorial(0) = 1
// factorial(n) = n × factorial(n-1) for n > 0

// Complexity:
// Time Complexity: O(n)  (one recursive call per number)
// Space Complexity: O(n) (recursion call stack)

using System;

public class FactorialRecursive
{
    static long Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
            return;
        }

        long result = Factorial(n);
        Console.WriteLine("Factorial of " + n + " is: " + result);
    }
}
