using System;
using System.Linq;

class Student
{
    public string Name{get;set;}
    public int Age{get;set;}
    public double Marks{get;set;}
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> arr = new List<Student>
        {
            new Student{Name="Ankit",Age=20,Marks=50},
            new Student{Name="Rohan",Age=21,Marks=45},
            new Student{Name="Sohan",Age=22,Marks=45},
            new Student{Name="Karan",Age=23,Marks=40},
        };
        var newArr = arr.OrderByDescending(x=>x.Marks).ThenBy(a=>a.Age).ToList();
        foreach(var it in newArr)
        {
            Console.WriteLine($"{it.Name} | {it.Marks} | {it.Age}");
        }
    }
}