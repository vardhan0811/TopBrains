using System;


    public class LuckyNumbers
    {
        public static void Run()
        {
            Console.WriteLine("Welcome to the Lucky Numbers program!");
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int count = 0;

            for (int i = m; i <= n; i++)
            {
                if (isPrime(i)) continue;
                int sum = SumOfDigits(i);
                int square = SumOfDigits(i * i);

                if (square == sum * sum)
                {
                    count++;
                }
            }
            Console.WriteLine($"Total lucky numbers found: {count}");
        }

        private static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        private static bool isPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
