using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main()
    {
        int feet = 5;
        double cm = Math.Round(feet*30.48,2,MidpointRounding.AwayFromZero);

        Console.WriteLine(cm);
    }
}
