using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n < 2)
            return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0)
                return false;
        return true;
    }

    static void Main()
    {
        Console.Write("Enter n: ");
        if (int.TryParse(Console.ReadLine(), out int n))
            Console.WriteLine(IsPrime(n) ? "Prime" : "Composite");
    }
}
