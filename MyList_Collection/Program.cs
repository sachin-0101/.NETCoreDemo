using MyList_Collection;
class Program
{
    public static void Main(string[] args)
    {
        MyList list = new MyList();

        list.Add("Hello");
        list.Add("World");
        list.Add(42);
        list.Add(3.14);

        Console.WriteLine($"Count: {list.Count}"); // Output: Count: 4
        Console.WriteLine($"Element at index 2: {list[2]}");

        list.RemoveAt(1); // Remove "World"
        Console.WriteLine($"Count after removal: {list.Count}"); // Output: 3

        list.Remove(42); // Remove 42
        Console.WriteLine($"Count after removing 42: {list.Count}"); // Output: 2

        list.Clear(); // Clear the list
        Console.WriteLine($"Count after clearing: {list.Count}"); // Output: 0

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
