using System;

/// <summary>
/// Demonstrates swapping two integer values using ref parameters without a temporary variable.
/// </summary>
class SwapUsingRef
{
    /// <summary>
    /// Runs the swap demonstration. Initializes two integers, displays their values before and after swapping.
    /// </summary>
    public static void Run()
    {
        int a = 10;
        int b = 20;

        Console.WriteLine($"Before Swap: a = {a}, b = {b}");

        Swap(ref a, ref b); // Swap the values of a and b

        Console.WriteLine($"After Swap: a = {a}, b = {b}");
    }

    /// <summary>
    /// Swaps the values of two integers using ref parameters and arithmetic operations.
    /// </summary>
    /// <param name="x">Reference to the first integer.</param>
    /// <param name="y">Reference to the second integer.</param>
    static void Swap(ref int x, ref int y)
    {
        // Swapping without a temporary variable using addition and subtraction
        x = x + y; // x now holds the sum of x and y
        y = x - y; // y is assigned the original value of x
        x = x - y; // x is assigned the original value of y
    }
}