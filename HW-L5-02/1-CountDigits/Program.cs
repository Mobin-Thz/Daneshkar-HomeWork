namespace _1_CountDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a positive integer:");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int n) || n <= 0)
            {
                Console.WriteLine("Invalid input! Please enter a positive integer.");
                return;
            }

            int digits = n.ToString().Length;
            Console.WriteLine($"Number of digits: {digits}");
            
        }

    }
}

