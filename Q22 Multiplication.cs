using System;

/// <summary>
/// Provides functionality to generate a row of a multiplication table for a given number.
/// </summary>
public class Multiplication
{
    /// <summary>
    /// Generates an array representing the multiplication table row for a given number.
    /// </summary>
    /// <param name="m">The base number for the multiplication table.</param>
    /// <param name="n">The number of multiples to generate.</param>
    /// <returns>An array containing the first n multiples of m.</returns>
    public static int[] GetRow(int m, int n)
    {
        if (n == 0) return new int[0]; // Return empty array if n is 0
        int[] row = new int[n]; // Array to store the result
        // Loop from 1 to n to fill the array with multiples of m
        for (int i = 1; i <= n; i++)
        {
            row[i - 1] = m * i; // Calculate and assign the multiple
        }
        return row;
    }
}