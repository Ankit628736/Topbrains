using System;
class Program
{
    public static void fun(ref int a,ref int b,out int x,out int y)
    {
        x=b;
        y=a;
    }
    static void Main(string[] args)
    {
        int a = 5;
        int b = 3;
        int x,y;
        fun(ref a,ref b,out x,out y);
        Console.WriteLine($"{x} | {y}");
    }
}