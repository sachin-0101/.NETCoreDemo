//Write a program that keeps asking the user to enter a number until they enter 0. After that, print the sum of all entered numbers

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int Sum = 0;
        while (true)
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                break;
            }
            Sum += num;
        }
        Console.WriteLine("Sum of all numbers is : " + Sum);
    }
}