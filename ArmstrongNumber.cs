// Problem: Check if a Number is Armstrong

// Question:
// Write a program to check whether a given number is an Armstrong number.
// An n-digit number is an Armstrong number if the sum of its digits raised 
// to the power n is equal to the number itself.

// Input:
// An integer entered by the user

// Output:
// "Armstrong Number" if it satisfies the condition
// "Not an Armstrong Number" otherwise

// Example:
// Input: 153
// Output: Armstrong Number
// Explanation: 1^3 + 5^3 + 3^3 = 153

// Input: 123
// Output: Not an Armstrong Number

// Complexity:
// Time Complexity: O(d)  (d = number of digits)
// Space Complexity: O(1)  (constant extra space)

using System;

public class ArmstrongNumber
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int original = num;
        int sum = 0;
        int digits = num.ToString().Length;

        while (num > 0)
        {
            int digit = num % 10;
            sum += (int)Math.Pow(digit, digits);
            num /= 10;
        }

        if (sum == original)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not an Armstrong Number");
    }
}
