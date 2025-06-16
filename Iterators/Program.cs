using Iterators;

class Program
{
    static void Main()
    {
        PrimeNumberCollection primes = new PrimeNumberCollection(10, 30);

        Console.WriteLine("Prime numbers between 10 and 30:");
        foreach (int prime in primes)
        {
            Console.WriteLine(prime);
        }
    }
}
