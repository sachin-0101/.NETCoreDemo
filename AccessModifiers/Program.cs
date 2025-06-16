using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of Person
            Person person = new Person("Sandip", 30);

            // Display person's information
            person.DisplayInfo();

            // Access public member
            Console.WriteLine($"Name: {person.Name}");

            // The following lines would cause compile-time errors due to access modifiers
            // Console.WriteLine(person.age); // Error: 'Person.age' is inaccessible due to its protection level
            // Console.WriteLine(person

        }
    }
}