namespace _9_DuplicateNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers separated by space: ");
            string input = Console.ReadLine();

            int[] numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();

            var duplicates = FindDuplicates(numbers);

            if (duplicates.Count > 0)
            {
                Console.WriteLine("Duplicates found: " + string.Join(", ", duplicates));
            }
            else
            {
                Console.WriteLine("No duplicates found.");
            }
        }

        static List<int> FindDuplicates(int[] arr)
        {
            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            foreach (int num in arr)
            {
                if (!seen.Add(num)) 
                {
                    duplicates.Add(num);
                }
            }

            return duplicates.ToList();
        }
    }
}

