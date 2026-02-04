using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter radius: ");
        double num = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI*num*num;
        Console.WriteLine($"Area: {area:F2}");
    }
}
