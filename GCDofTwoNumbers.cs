// Problem: Find the GCD (Greatest Common Divisor) of Two Numbers

// Question:
// Write a program to find the GCD of two numbers using the Euclidean Algorithm.
// The GCD is the largest number that divides both numbers without leaving a remainder.

// Input:
// - Two integers (a and b)

// Output:
// - GCD of the two numbers

// Example:
// Input: a = 48, b = 18
// Output: GCD = 6
//
// Input: a = 101, b = 103
// Output: GCD = 1

// Notes:
// Euclidean Algorithm:
// gcd(a, b) = gcd(b, a % b) until b = 0, then gcd = a

// Complexity:
// Time Complexity: O(log(min(a, b)))
// Space Complexity: O(1)

using System;

public class GCDofTwoNumbers
{
    public static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int gcd = GCD(a, b);
        Console.WriteLine("GCD = " + gcd);
    }
}
