using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;


public record Student(string Name, int Score);

/// <summary>
/// Provides functionality to format student data as a JSON string based on score filtering and sorting.
/// </summary>
public class StringFormat
{
    /// <summary>
    /// Builds a JSON array string of students who meet the minimum score requirement, sorted by score (descending) and name (ascending).
    /// </summary>
    /// <param name="items">Array of strings in the format "Name:Score".</param>
    /// <param name="minScore">The minimum score a student must have to be included.</param>
    /// <returns>A JSON string representing the filtered and sorted students.</returns>
    public static string BuildJson(string[] items, int minScore)
    {
        if (items == null || items.Length == 0)
            return "[]"; // Return empty JSON array if input is null or empty

        List<Student> students = new List<Student>();
        foreach(string item in items)
        {
            int colonIndex = item.IndexOf(':');
            if (colonIndex == -1) continue; // Skip if format is invalid
            string name = item.Substring(0, colonIndex);
            if (!int.TryParse(item.Substring(colonIndex + 1), out int score))
                continue; // Skip if score is not a valid integer
            if (score >= minScore) students.Add(new Student(name, score)); // Add student if score meets minimum
        }
        // Sort students by score descending, then by name ascending
        var sorted = students
            .OrderByDescending(s => s.Score)
            .ThenBy(s => s.Name)
            .ToList();
        
        return JsonSerializer.Serialize(sorted); // Serialize the sorted list to JSON
    }
}