using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public class Student
    {
        public string Name { get; set; }
        public int Percentage { get; set; }
    }

    public static void Main(string[] args)
    {
        Percentage();
    }

    public static void Percentage()
    {
        var students = new List<Student>
        {
            new Student { Name = "Sachin", Percentage = 50 },
            new Student { Name = "Mahesh", Percentage = 70 },
            new Student { Name = "Sandip", Percentage = 88 },
            new Student { Name = "Manasi", Percentage = 35 },
            new Student { Name = "Ramesh", Percentage = 34 }
        };

        try
        {
            // Group students by result category
            var distinction = new List<Student>();
            var firstClass = new List<Student>();
            var secondClass = new List<Student>();
            var fail = new List<Student>();

            foreach (var student in students)
            {
                if (student.Percentage > 75)
                    distinction.Add(student);
                else if (student.Percentage > 60)
                    firstClass.Add(student);
                else if (student.Percentage >= 35)
                    secondClass.Add(student);
                else
                    fail.Add(student);
            }

            PrintCategory("Distinction (greater than 75%)", distinction, "Distinction");
            PrintCategory("First Class (greater than 60%)", firstClass, "First Class");
            PrintCategory("Second Class (35% to 60%)", secondClass, "Second Class");
            PrintCategory("Fail (below 35%)", fail, "Fail");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error : " + ex.Message);
        }
    }

    private static void PrintCategory(string header, List<Student> students, string resultLabel)
    {
        Console.WriteLine($"\n------------------------------");
        Console.WriteLine($"Students with {header}:");

        if (students.Count == 0)
        {
            Console.WriteLine("None");
            return;
        }

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name} : {student.Percentage}%, Result: {resultLabel}");
        }
    }
}