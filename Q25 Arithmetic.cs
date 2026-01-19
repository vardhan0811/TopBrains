using System;

public class Arithmetic
{
    public static string Evaluate(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression)) return "Error: Invalid Expression";
        string[] parts = expression.Split(' ');

        if (parts.Length != 3) return "Error: Invalid Expression";
        if(!int.TryParse(parts[0], out int a) || !int.TryParse(parts[2], out int b)) return "Error: Invalid Number";
        
        string op = parts[1];
        switch(op)
        {
            case "+":
                return (a + b).ToString();
            case "-":
                return (a - b).ToString();
            case "*":
                return (a * b).ToString();
            case "/":
                return b != 0 ? (a / b).ToString() : "Error: Division by Zero";
            default:
                return "Error: Unknown Operator";
        }
    }
}