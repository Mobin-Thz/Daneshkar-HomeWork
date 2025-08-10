namespace _10_MaxProductOfThree
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter integers separated by space (at least 3 numbers):");
            string input = Console.ReadLine();

            // Parse input
            int[] numbers;
            try
            {
                numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

                if (numbers.Length < 3)
                {
                    Console.WriteLine("You must enter at least 3 numbers!");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("Invalid input! Please enter integers separated by spaces.");
                return;
            }

            int maxProduct = MaxProductOfThree(numbers);

            Console.WriteLine($"Maximum product of three numbers is: {maxProduct}");
        }

        static int MaxProductOfThree(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length;

            int option1 = nums[n - 1] * nums[n - 2] * nums[n - 3];
            int option2 = nums[0] * nums[1] * nums[n - 1];

            return Math.Max(option1, option2);
        }

    }

}

