namespace _3_SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter an integer: ");
            if (!long.TryParse(Console.ReadLine(), out long n))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            long sum = SumOfDigits(n);
            Console.WriteLine($"Sum of digits: {sum}");
        }

        static long SumOfDigits(long number)
        {
            number = Math.Abs(number);   
            long sum = 0;

            while (number > 0)
            {
                sum += number % 10;     
                number /= 10;          
            }

            return sum; 
        }
        
    }
}

