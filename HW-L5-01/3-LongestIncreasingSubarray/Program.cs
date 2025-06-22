namespace _3_LongestIncreasingSubarray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(LongestIncreasingSubarray(new[] { 1, 2, 2, 3, 4, 1, 2 }));  // 3 ([2,3,4])
            Console.WriteLine(LongestIncreasingSubarray(new[] { 5, 6, 7, 1, 2, 3, 4 }));  // 4 ([1,2,3,4])
            Console.WriteLine(LongestIncreasingSubarray(new[] { 9, 8, 7 }));              // 1

        }

        static int LongestIncreasingSubarray(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return 0;

            int maxLen = 1;
            int currLen = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    currLen++;
                    if (currLen > maxLen)
                        maxLen = currLen;
                }
                else
                {
                    currLen = 1;
                }
            }

            return maxLen;
        }

    }
}
