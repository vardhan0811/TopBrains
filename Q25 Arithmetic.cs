using System;


public class Arithmetic
{
    /// <summary>
    /// Evaluates a simple arithmetic expression in the format "a op b" (e.g., "3 + 4").
    /// </summary>
    /// <param name="expression">A string containing the arithmetic expression.</param>
    /// <returns>The result as a string, or an error message if the input is invalid.</returns>
    public static string Evaluate(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression)) return "Error: Invalid Expression"; // Check for empty input
        string[] parts = expression.Split(' '); // Split the expression by spaces

        if (parts.Length != 3) return "Error: Invalid Expression"; // Must have exactly 3 parts
        if(!int.TryParse(parts[0], out int a) || !int.TryParse(parts[2], out int b)) return "Error: Invalid Number"; // Parse operands
        
        string op = parts[1]; // Operator
        switch(op)
        {
            case "+":
                return (a + b).ToString(); // Addition
            case "-":
                return (a - b).ToString(); // Subtraction
            case "*":
                return (a * b).ToString(); // Multiplication
            case "/":
                return b != 0 ? (a / b).ToString() : "Error: Division by Zero"; // Division with zero check
            default:
                return "Error: Unknown Operator"; // Invalid operator
        }
    }
}