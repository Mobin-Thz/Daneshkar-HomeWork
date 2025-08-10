namespace _2_PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter an integer:");
            int input = int.Parse(Console.ReadLine());

            if (IsPrime(input))
                Console.WriteLine("Prime number.");
            else
                Console.WriteLine("Not a prime number.");
          
        }
        static bool IsPrime(int n)
        {
            if (n <= 1) return false; 

            int limit = (int)Math.Sqrt(n);
            for (int i = 2; i <= limit; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

    }
}

