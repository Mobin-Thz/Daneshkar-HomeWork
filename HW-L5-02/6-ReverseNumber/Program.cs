namespace _6_ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int reversed = ReverseNumber(n);
                Console.WriteLine($"Reversed number: {reversed}");
                Console.WriteLine($"Reversed number type: {reversed.GetType()}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

        }

        static int ReverseNumber(int num)
        {
            int result = 0;
            int number = Math.Abs(num);

            while (number > 0)
            {
                int digit = number % 10;
                result = result * 10 + digit;
                number /= 10;
            }

            return num < 0 ? -result : result; 
        }
    
    }
}
