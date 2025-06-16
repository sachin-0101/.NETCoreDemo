//Create a simple menu-driven program that displays options to the user and repeats until the user chooses to exit.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int choice;
        do
        {
            Console.WriteLine("1. Say Hello");
            Console.WriteLine("2. Show Date");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice : ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------");
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hello Sachin");
                    break;

                case 2:
                    Console.WriteLine("Today's Date :" + DateTime.Now.ToString("dd/MM/yyyy"));
                    break;

                case 3:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Retry with valid choice");
                    break;

            }
            Console.WriteLine("------------------------");
        }
        while (choice != 3);
    }
}