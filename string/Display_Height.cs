using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter height: ");
            int h = int.Parse(Console.ReadLine());
            if (h < 0 || h>300)
            {
                throw new InvalidOperationException("Height Must be grater than 0 Or Less then 300");
            }
            else if (h < 150)
            {
                Console.WriteLine("Short");
            }else if(h>=150 && h <= 180)
            {
                Console.WriteLine("Avrage");
            }
            else
            {
                Console.WriteLine("Tall");
            }
        }catch(InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}