using System;

public class Greatest
{
    /// <summary>
    /// Returns the largest value among three integers.
    /// </summary>
    /// <param name="a">First integer.</param>
    /// <param name="b">Second integer.</param>
    /// <param name="c">Third integer.</param>
    /// <returns>The largest integer value.</returns>
    public static int GetLargest(int a, int b, int c)
    {
        // Check if 'a' is greater than or equal to both 'b' and 'c'
        if (a >= b && a >= c)
            return a;
        // Check if 'b' is greater than or equal to both 'a' and 'c'
        else if (b >= a && b >= c)
            return b;
        // Otherwise, 'c' is the largest
        else
            return c;
    }
}