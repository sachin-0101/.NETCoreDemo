

namespace AccessModifiers
{
    public class Person
    {
        // Access Modifiers
        public string Name;                        // Accessible from anywhere
        private int age;                           // Only within Person
        protected string Gender;                   // Within Person and derived classes
        internal string Nationality;               // Anywhere in the same assembly
        protected internal string Occupation;      // Derived classes or same assembly
        private protected string Hobby;            // Derived classes in same assembly only

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            this.age = age;
            Gender = "Not Specified";
            Nationality = "India";
            Occupation = "Software Engineer";
            Hobby = "Photography";
        }

        // Public Method
        public void DisplayInfo()
        {
            System.Console.WriteLine($"Name: {Name}");
            System.Console.WriteLine($"Age: {age}");
            System.Console.WriteLine($"Gender: {Gender}");
            System.Console.WriteLine($"Nationality: {Nationality}");
            System.Console.WriteLine($"Occupation: {Occupation}");
            System.Console.WriteLine($"Hobby: {Hobby}");
        }
    }
}