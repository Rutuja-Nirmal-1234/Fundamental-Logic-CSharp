// Problem: Handle Division by Zero using Try-Catch

// Question:
// Write a program to perform division of two numbers entered by the user
// and handle division by zero using try-catch block.

// Input:
// Two integers: dividend and divisor

// Output:
// Result of division if valid, otherwise an error message

// Example:
// Input: dividend = 10, divisor = 2
// Output: Result: 5
//
// Input: dividend = 10, divisor = 0
// Output: Error: Division by zero is not allowed.

// Notes:
// - Use try-catch to handle DivideByZeroException
// - Catch any other unexpected exceptions

// Complexity:
// Time Complexity: O(1)
// Space Complexity: O(1)

using System;

public class DivisionTryCatch
{
    public static void Main(string[] args)
    {
        Console.Write("Enter dividend: ");
        int dividend = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        try
        {
            int result = dividend / divisor;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
