/// <summary>
/// Provides functionality to merge two sorted arrays into a single sorted array.
/// </summary>
public class SortedArrays
{
    /// <summary>
    /// Merges two sorted arrays into a single sorted array.
    /// </summary>
    /// <typeparam name="T">The type of the array elements, must implement IComparable&lt;T&gt;.</typeparam>
    /// <param name="a">The first sorted array.</param>
    /// <param name="b">The second sorted array.</param>
    /// <returns>A new sorted array containing all elements from both input arrays.</returns>
    public static T[] Merge<T>(T[] a, T[] b) where T : IComparable<T>
    {
        int n = a.Length;
        int m = b.Length;

        T[] merged = new T[n + m]; // Result array

        int i = 0, j = 0, k = 0; // i for a, j for b, k for merged

        // Merge elements from both arrays in sorted order
        while (i < n && j < m)
        {
            if (a[i].CompareTo(b[j]) <= 0)
            {
                merged[k++] = a[i++]; // Take from a if smaller or equal
            }
            else
            {
                merged[k++] = b[j++]; // Take from b if smaller
            }
        }

        // Copy any remaining elements from a
        while (i < n)
        {
            merged[k++] = a[i++];
        }

        // Copy any remaining elements from b
        while (j < m)
        {
            merged[k++] = b[j++];
        }

        return merged;
    }
}
