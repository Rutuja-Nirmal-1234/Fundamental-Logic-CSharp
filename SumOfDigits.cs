// Problem: Sum of Digits of a Number

// Question:
// Write a program to calculate the sum of digits of a given integer number.

// Input:
// An integer entered by the user

// Output:
// Sum of all digits in the number

// Example:
// Input: 1234
// Output: 10
// Explanation: 1 + 2 + 3 + 4 = 10

// Notes:
// - Handle negative numbers by taking absolute value
// - Extract digits using modulus (%) and division (/)

// Complexity:
// Time Complexity: O(d)  (d = number of digits)
// Space Complexity: O(1)  (constant extra space)

using System;

public class SumOfDigits
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int n = Math.Abs(num); // handle negative numbers

        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }

        Console.WriteLine("Sum of digits: " + sum);
    }
}
