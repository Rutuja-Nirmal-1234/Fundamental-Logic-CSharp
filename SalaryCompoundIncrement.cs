// Problem: Salary After Given Years – Compound Percentage Increment Method

// Question:
// Calculate the salary of an employee after a given number of years,
// assuming a fixed percentage increment is applied each year.
// Formula: New Salary = Current Salary * (1 + Increment/100)^Years

// Input:
// - Current salary (decimal or integer)
// - Annual increment percentage
// - Number of years

// Output:
// Salary after given years (with compound percentage increment)

// Example:
// Input: Current Salary = 50000, Increment% = 10, Years = 2
// Output: Salary after 2 years: 60500
// Explanation: Year 1 = 50000 * 1.10 = 55000
//              Year 2 = 55000 * 1.10 = 60500

// Complexity:
// Time Complexity: O(1)  (direct formula)
// Space Complexity: O(1)

using System;

public class SalaryCompoundIncrement
{
    public static void Main(string[] args)
    {
        Console.Write("Enter current salary: ");
        decimal currentSalary = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter annual increment (%): ");
        decimal incrementPercent = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter number of years: ");
        int years = Convert.ToInt32(Console.ReadLine());

        decimal factor = 1 + (incrementPercent / 100);
        decimal newSalary = currentSalary * (decimal)Math.Pow((double)factor, years);

        Console.WriteLine($"Salary after {years} years: {Math.Round(newSalary, 2)}");
        // Console.Write("new salary : " + newsalary.ToString("F2"));

    }
}
