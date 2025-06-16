using CustomCollection;

public class Program
{
    static void Main()
    {
        PersonCollection collection = new PersonCollection();

        collection.Add(new Person { Name = "Alice", Age = 30 });
        collection.Remove(new Person { Name = "Bob", Age = 25 });

        Console.WriteLine("All persons:");
        collection.DisplayAll();

        Console.WriteLine($"Total persons: {collection.Count}");

        // Accessing a specific person
        Console.WriteLine("First person:");
        Console.WriteLine(collection[0]);
    }
}