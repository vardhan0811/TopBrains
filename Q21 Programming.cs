using System;


    /// <summary>
    /// Provides functionality to find and count "lucky numbers" in a given range.
    /// A lucky number is a non-prime number where the sum of the digits of its square
    /// is equal to the square of the sum of its digits.
    /// </summary>
    public class LuckyNumbers
    {
        /// <summary>
        /// Runs the Lucky Numbers program. Prompts the user for two integers (m and n),
        /// then counts and displays the number of lucky numbers in the range [m, n].
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("Welcome to the Lucky Numbers program! Please enter two integers (m and n) separated by a space:");
            string? line = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(line))
            {
                Console.WriteLine("Invalid input. Please enter two integers separated by a space.");
                return;
            }
            string[] input = line.Split();
            if (input.Length < 2)
            {
                Console.WriteLine("Invalid input. Please enter two integers separated by a space.");
                return;
            }
            int m = int.Parse(input[0]); // Start of range
            int n = int.Parse(input[1]); // End of range
            int count = 0; // Counter for lucky numbers

            // Iterate through the range from m to n
            for (int i = m; i <= n; i++)
            {
                if (isPrime(i)) continue; // Skip prime numbers
                int sum = SumOfDigits(i); // Sum of digits of i
                int square = SumOfDigits(i * i); // Sum of digits of i squared

                // Check if the sum of digits of the square equals the square of the sum of digits
                if (square == sum * sum)
                {
                    count++;
                }
            }
            Console.WriteLine($"Total lucky numbers found: {count}");
        }

        /// <summary>
        /// Calculates the sum of the digits of a given integer.
        /// </summary>
        /// <param name="number">The integer whose digits will be summed.</param>
        /// <returns>The sum of the digits.</returns>
        private static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10; // Add the last digit to sum
                number /= 10; // Remove the last digit
            }
            return sum;
        }

        /// <summary>
        /// Determines whether a given integer is a prime number.
        /// </summary>
        /// <param name="number">The integer to check for primality.</param>
        /// <returns>True if the number is prime; otherwise, false.</returns>
        private static bool isPrime(int number)
        {
            if (number <= 1) return false; // 0 and 1 are not prime
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false; // Found a divisor, not prime
            }
            return true;
        }
    }
