
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number to Generate Mutiplication Table");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("-----------------------------");
        Console.WriteLine($"Table of {num} as shown below : ");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num * i);
        }
    }
}