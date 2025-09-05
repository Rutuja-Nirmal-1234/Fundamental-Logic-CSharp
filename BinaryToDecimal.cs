// Problem: Convert a Binary Number to Decimal

// Question:
// Write a program to convert a binary number (entered as a string)
// into its decimal equivalent.

// Input:
// - A binary number as string (e.g., "1011")

// Output:
// - Decimal equivalent of the binary number

// Example:
// Input: binary = "1011"
// Output: Decimal = 11
//
// Input: binary = "11010"
// Output: Decimal = 26

// Notes:
// Traverse the binary string from left to right,
// for each digit multiply by 2^(position) and sum up.

// Complexity:
// Time Complexity: O(n)  (where n = number of binary digits)
// Space Complexity: O(1)

using System;

public class BinaryToDecimal
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a binary number: ");
        string binary = Console.ReadLine();

        int decimalValue = 0;
        int power = 0;

        // Traverse from rightmost bit
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            if (binary[i] == '1')
            {
                decimalValue += (int)Math.Pow(2, power);
            }
            power++;
        }

        Console.WriteLine("Decimal = " + decimalValue);
    }
}
