using System;

public class Height
{
    /// <summary>
    /// Returns a category string based on the given height in centimeters.
    /// </summary>
    /// <param name="heightCm">Height in centimeters.</param>
    /// <returns>"Short" if less than 150 cm, "Average" if less than 180 cm, otherwise "Tall".</returns>
    public static string GetCategory(int heightCm)
    {
        // If height is less than 150 cm, categorize as "Short"
        if (heightCm < 150)
        {
            return "Short";
        }
        // If height is less than 180 cm but at least 150 cm, categorize as "Average"
        else if (heightCm < 180)
        {
            return "Average";
        }
        // If height is 180 cm or more, categorize as "Tall"
        else
        {
            return "Tall";
        }
    }
}