using MathUtilities;
using System;
using System.Security.Claims;

//Assemblies & Class Libraries:
//Problem: Create a class library project named MathUtilities with classes for basic arithmetic operations. 
//Reference this library in a console application and use its methods to perform calculations.
//Solution: Create a class library named MathUtilities with an Arithmetic class that provides methods for addition, subtraction, multiplication, and division.

class Program
{
    static void Main()
    {
        var calc = new Arithmetic();

        double a = 30;
        double b = 10;

        // Use methods from the library and print results
        Console.WriteLine("Using MathUtilities.Arithmetic class:");
        Console.WriteLine("---------------------------------------");

        Console.WriteLine($"Add: {a} + {b} = {calc.Add(a, b)}");
        Console.WriteLine($"Subtract: {a} - {b} = {calc.Subtract(a, b)}");
        Console.WriteLine($"Multiply: {a} * {b} = {calc.Multiply(a, b)}");
        Console.WriteLine($"Divide: {a} / {b} = {calc.Divide(a, b)}");
    }
}
