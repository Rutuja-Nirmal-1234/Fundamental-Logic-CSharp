// Problem: Check if a Number is Prime

// Question:
// Write a program to check whether a given number is prime or not.
// A prime number is a number greater than 1 that has no divisors other than 1 and itself.

// Input:
// An integer entered by the user

// Output:
// "Prime Number" if the number is prime
// "Not a Prime Number" otherwise

// Example:
// Input: 7
// Output: Prime Number
//
// Input: 10
// Output: Not a Prime Number

// Notes:
// A number is not prime if it is divisible by any integer from 2 to sqrt(n).

// Complexity:
// Time Complexity: O(√n)  (check divisibility up to square root)
// Space Complexity: O(1)

using System;

public class PrimeCheck
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num <= 1)
        {
            Console.WriteLine("Not a Prime Number");
            return;
        }

        bool isPrime = true;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.WriteLine("Prime Number");
        else
            Console.WriteLine("Not a Prime Number");
    }
}
