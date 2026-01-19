public class Program
{
    public static void Main()
    {
        LuckyNumbers.Run();
        int[] result = Multiplication.GetRow(2, 5);
        Console.WriteLine(string.Join(", ", result));
        SwapUsingRef.Run();
    }
}