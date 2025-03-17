namespace _5_SumOFOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // without checking if the number is odd or even

            here:

                Console.WriteLine("Give me a a number: ");
                string temp = Console.ReadLine();
                int theNumber = int.Parse(temp);

                if (theNumber < 1)
                {
                    Console.WriteLine("The number is invalid. \n Try again. ");
                goto here;

                }

                int sumOfOdds = 0;
                for (int i = 1; i <= theNumber; i += 2)
                {
                    sumOfOdds += i;

                }

                Console.WriteLine($"Sum of odd numbers 1 to {theNumber} is {sumOfOdds}. ");
                Console.ReadKey();


            

        }
    }
}
