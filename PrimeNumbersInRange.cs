// Problem: Print All Prime Numbers Within a Range

// Question:
// Write a program to print all prime numbers within a given range [start, end].

// Input:
// Two integers: start and end of the range

// Output:
// All prime numbers between start and end (inclusive)

// Example:
// Input: start = 10, end = 20
// Output: 11 13 17 19

// Notes:
// Use a helper function to check if a number is prime, 
// and call it for each number in the range.

// Complexity:
// Time Complexity: O((end - start) * √n)  (prime check for each number)
// Space Complexity: O(1)

using System;

public class PrimeNumbersInRange
{
    static bool IsPrime(int num)
    {
        if (num <= 1) return false;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter Start of Range: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter End of Range: ");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Prime numbers between {start} and {end}:");

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
                Console.Write(i + " ");
        }
    }
}
