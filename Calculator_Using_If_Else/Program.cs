
using System;

public class Program
{
    public static void Main(string[] args)
    {
        double firstNum, secondNum, result;
        string Operator;

        try
        {
            Console.WriteLine("Enter first number : ");
            firstNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second number : ");
            secondNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Operator (Allowed only + - * /) : ");
            Operator = Console.ReadLine();

            if (Operator == "+")
            {
                result = firstNum + secondNum;
                Console.WriteLine("Addition of is : " + result);
            }
            else if (Operator == "-")
            {
                result = firstNum - secondNum;
                Console.WriteLine("Substraction is  : " + result);
            }
            else if (Operator == "*")
            {
                result = firstNum * secondNum;
                Console.WriteLine("Multiplication is  : " + result);
            }
            else if (Operator == "/")
            {
                result = firstNum / secondNum;
                Console.WriteLine("Division is  : " + result);
            }
            else
            {
                Console.WriteLine("Invalid operator !! Retry with correct operator + - * /");
            }
        }
        catch
        {
            Console.WriteLine("Invalid Input !! Please enter digits for first number and second number");
        }
    }
}