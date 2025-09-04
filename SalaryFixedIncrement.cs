// Problem: Salary After Given Years – Fixed Increment Method

// Question:
// Calculate the salary of an employee after a given number of years
// assuming a fixed annual increment. 
// New Salary = Current Salary + (Increment * Number of Years)

// Input:
// - Current salary (decimal or integer)
// - Annual increment
// - Number of years

// Output:
// Salary after given years

// Example:
// Input: Current Salary = 50000, Increment = 5000, Years = 3
// Output: Salary after 3 years: 65000
// Explanation: 50000 + (5000*3) = 65000

// Complexity:
// Time Complexity: O(1)  (single formula)
// Space Complexity: O(1)

using System;

public class SalaryFixedIncrement
{
    public static void Main(string[] args)
    {
        Console.Write("Enter current salary: ");
        decimal currentSalary = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter annual increment: ");
        decimal increment = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter number of years: ");
        int years = Convert.ToInt32(Console.ReadLine());

        decimal newSalary = currentSalary + (increment * years);
        Console.WriteLine($"Salary after {years} years: {newSalary}");
    }
}
