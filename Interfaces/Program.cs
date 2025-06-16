using Interfaces;

class Program
{
    static void Main()
    {
        List<IPayable> payables = new List<IPayable>
        {
            new Employee("Sachin", 4000m),
            new Contractor("Sandip", 50m, 160),
            new Employee("Ram", 4500m),
            new Contractor("Sita", 60m, 120)
        };

        Console.WriteLine("Payments to be made:");
        foreach (IPayable payable in payables)
        {
            Console.WriteLine($"{payable} - Pay: {payable.CalculatePay():F2}");
        }
    }
}
