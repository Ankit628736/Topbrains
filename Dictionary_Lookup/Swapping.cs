using System;
class Program
{
    public static void Method1(ref int a,ref int b)
    {
        int t = a;
        a = b;
        b = t;
    }
    public static void Method2(out int a,out int b,int x,int y)
    {
        a = y;
        b = x;
    }
    static void Main(string[] args)
    {
        int a = 5;
        int b = 3;
        int x = a,y = b;
        Console.WriteLine($"Before Any Method: {a} | {b}");
        Method1(ref a,ref b);
        Console.WriteLine($"After Method1: {a} | {b}");
        Method2(out a,out b,x,y);
        Console.WriteLine($"After Method2: {a} | {b}");
    }
}
