using System;

public class TimeConversion
{
    public static void Main(string[] args)
    {
        Console.WriteLine(fun(225));
        Console.WriteLine(fun(90));
        Console.WriteLine(fun(11));
    }
    public static string fun(int totalSeconds)
    {
        int minutes = totalSeconds / 60;

        int seconds = totalSeconds % 60;

        return $"{minutes}:{seconds:D2}";
    }
}