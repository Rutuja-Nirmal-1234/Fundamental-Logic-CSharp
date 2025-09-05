// Problem: Check if a number is a Perfect Square

// Question:
// Write a program to check whether a given number is a perfect square or not.
// A perfect square is a number that can be expressed as the product of an integer with itself.

// Input:
// - A single integer (n)

// Output:
// - "Perfect Square" if n is a perfect square
// - "Not a Perfect Square" otherwise

// Example:
// Input: n = 25
// Output: Perfect Square
//
// Input: n = 20
// Output: Not a Perfect Square

// Notes:
// Use Math.Sqrt(n) and check if the square root is an integer.

// Complexity:
// Time Complexity: O(1)
// Space Complexity: O(1)

using System;

public class PerfectSquareCheck
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double sqrt = Math.Sqrt(n);
        if (sqrt == (int)sqrt)
            Console.WriteLine("Perfect Square");
        else
            Console.WriteLine("Not a Perfect Square");
    }
}
