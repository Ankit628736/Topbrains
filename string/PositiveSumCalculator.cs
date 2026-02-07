using System;

public class PositiveSumCalculator
{
    public static void Main(string[] args)
    {
        int[] nums = { 10, -5, 20, 0, 30 };
        long sum = 0;
        foreach (int n in nums)
        {
            if (n == 0) break;
            if (n < 0) continue;
            sum += n;
        }
        Console.WriteLine($"Total Sum: {(int)sum}");
    }
}
