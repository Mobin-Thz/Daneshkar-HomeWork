using System.Text;

namespace _7_NumberToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer (non-negative): ");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            {
                string binary = ToBinary(number);
                Console.WriteLine($"Binary representation: {binary}");
            }
            else
            {
                Console.WriteLine("Invalid input or negative number not supported.");
            }
        }
        static string ToBinary(int number)
        {
            if (number == 0) return "0";

            string binary = "";

            while (number > 0)
            {
                int remainder = number % 2;
                binary = remainder + binary;  
                number /= 2;
            }

            return binary;
        }
    }
    
}
