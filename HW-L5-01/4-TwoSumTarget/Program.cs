using System;
using System.Collections.Generic;


namespace _4_TwoSumTarget
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Two Sum Solver ===");

            // Get numbers from user
            Console.Write("Enter numbers separated by spaces: ");
            int[] nums = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            // Get target from user
            Console.Write("Enter target sum: ");
            int target = int.Parse(Console.ReadLine());

            // Solve
            var result = TwoSumSolver.TwoSum(nums, target);

            // Output result
            if (result.Item1 >= 0)
                Console.WriteLine($"✅ Pair found at indices {result.Item1} and {result.Item2} → ({nums[result.Item1]}, {nums[result.Item2]})");
            else
                Console.WriteLine("❌ No valid pair found.");
        }

        public class TwoSumSolver
        {
            public static (int, int) TwoSum(int[] nums, int target)
            {
                var lookup = new Dictionary<int, int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];
                    if (lookup.TryGetValue(complement, out int j))
                    {
                        return (j, i);
                    }

                    if (!lookup.ContainsKey(nums[i]))
                        lookup[nums[i]] = i;
                }

                return (-1, -1);
            }
        }
    }

}

