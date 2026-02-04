using System;

interface AreaInterface
{
    public double AreaMethod();
}

public class Circle : AreaInterface
{
    public static double r { get; set; }
    public double AreaMethod()
    {
        return Math.PI * r * r;
    }
}

class Rectangle : AreaInterface
{
    public static double w { get; set; }
    public static double h { get; set; }
    public double AreaMethod()
    {
        return w * h;
    }
}

class Triangle : AreaInterface
{
    public static double l { get; set; }
    public static double b { get; set; }
    public double AreaMethod()
    {
        return 0.5 * l * b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your Choice: \n1) Circle\n2) Rectangle\n3) Triangle");
        int ch = int.Parse(Console.ReadLine());

        if (ch == 1)
        {
            Console.WriteLine("Enter Radius: ");
            Circle.r = Convert.ToDouble(Console.ReadLine());
            AreaInterface ar = new Circle();
            Console.WriteLine($"Area of Circle: {ar.AreaMethod():F2}");
        }
        else if (ch == 2)
        {
            Console.WriteLine("Enter Height: ");
            Rectangle.h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            Rectangle.w = Convert.ToDouble(Console.ReadLine());
            AreaInterface ar = new Rectangle();
            Console.WriteLine($"Area of Rectangle: {ar.AreaMethod():F2}");
        }
        else if (ch == 3)
        {
            Console.WriteLine("Enter Length: ");
            Triangle.l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Breadth: ");
            Triangle.b = Convert.ToDouble(Console.ReadLine());
            AreaInterface ar = new Triangle();
            Console.WriteLine($"Area of Triangle: {ar.AreaMethod():F2}");
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}
