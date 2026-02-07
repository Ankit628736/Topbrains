using System;

public class LargestIntegerOfthreeNumber
{
    public static void Main(string[] args)
    {
        Console.WriteLine(GetLargestOFThree(-5, -1000, -10)); 
        Console.WriteLine(GetLargestOFThree(100,6000, 50));
        Console.WriteLine(GetLargestOFThree(500,6000, 50));
        Console.WriteLine(GetLargestOFThree(10,50, 15));  
        Console.WriteLine(GetLargestOFThree(100,-60, 50));
    }
    public static int GetLargestOFThree(int a, int b, int c)
    {
        int largest = a;

        if (b > largest)
        {
            largest = b;
        }

        if (c > largest)
        {
            largest = c;
        }

        return largest;
    }
}