namespace _4_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(IsPalindrome(number) ? "Palindrome" : "Not Palindrome");

        }

        static bool IsPalindrome(int n)
        {
            if (n < 0) return false; 
            int original = n;
            int reversed = 0;

            while (n > 0)
            {
                int digit = n % 10;       
                reversed = reversed * 10 + digit; 
                n /= 10;                   
            }

            return original == reversed;
        }
    }
}

