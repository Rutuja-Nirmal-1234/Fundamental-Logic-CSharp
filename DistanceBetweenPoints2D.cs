// Problem: Distance Between Two Points (2D)

// Question:
// Write a program to calculate the distance between two points (x1, y1) and (x2, y2) 
// in 2-dimensional Cartesian plane using the distance formula.
// Distance formula: √((x2 - x1)^2 + (y2 - y1)^2)

// Input:
// Coordinates of two points entered by the user

// Output:
// Distance between the two points

// Example:
// Input: Point1 (3, 4), Point2 (7, 1)
// Output: 5
// Explanation: √((7-3)^2 + (1-4)^2) = √(16 + 9) = √25 = 5

// Complexity:
// Time Complexity: O(1)  (single formula calculation)
// Space Complexity: O(1)  (constant extra space)

using System;

public class DistanceBetweenPoints2D
{
    public static void Main(string[] args)
    {
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine("Distance between points: " + distance);
    }
}
