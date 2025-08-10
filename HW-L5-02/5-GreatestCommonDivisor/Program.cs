namespace _5_GreatestCommonDivisor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int gcd = CalculateGCD(firstNumber, secondNumber);

            Console.WriteLine($"The Greatest Common Divisor of {firstNumber} and {secondNumber} is {gcd}.");
        }

        static int CalculateGCD(int number1, int number2)
        {
            number1 = Math.Abs(number1);
            number2 = Math.Abs(number2);

            while (number2 != 0)
            {
                int remainder = number1 % number2;
                number1 = number2;
                number2 = remainder;
            }

            return number1;
        }
    }
    
}
