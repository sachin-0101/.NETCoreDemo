using Indexers;

class Program
{
    static void Main()
    {
        WeekSchedule schedule = new WeekSchedule();

        schedule["Monday"] = "Team meeting";
        schedule["Wednesday"] = "Project work";
        schedule["Friday"] = "Code review";

        Console.WriteLine("Monday: " + schedule["Monday"]);
        Console.WriteLine("Wednesday: " + schedule["Wednesday"]);
        Console.WriteLine("Friday: " + schedule["Friday"]);

        // Trying an invalid day
        try
        {
            Console.WriteLine(schedule["Funday"]);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
