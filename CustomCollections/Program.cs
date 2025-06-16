using CustomCollections;

class Program
{
    static void Main()
    {
        var collection = new StudentCollection();

        collection.Add(new Student(1, "Sachin"));
        collection.Add(new Student(2, "Ram"));
        collection.Add(new Student(3, "Sandip"));

        // Attempt to add duplicate
        bool added = collection.Add(new Student(1, "Duplicate Sachin")); // Should be false

        Console.WriteLine("All Students:");
        foreach (var student in collection)
        {
            Console.WriteLine(student);
        }

        // Search
        Console.WriteLine("\nSearch for ID 2:");
        var studentById = collection.GetById(2);
        Console.WriteLine(studentById);

        // Remove
        collection.Remove(2);

        Console.WriteLine("\nAfter removing ID 2:");
        foreach (var student in collection)
        {
            Console.WriteLine(student);
        }
    }
}
