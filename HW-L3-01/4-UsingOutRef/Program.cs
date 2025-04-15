namespace _4_UsingOutRef
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many numbers are do tou want to compare?  ");
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Please enter the {i + 1} number");
                int inputnumber = int.Parse(Console.ReadLine());
                numbers[i] = inputnumber;
            }

            ArrayAnalyzer.AnalyzeArray(numbers, ref ArrayAnalyzer.max, out ArrayAnalyzer.average);
            Console.ReadKey();
        }
        public class ArrayAnalyzer
        {
            public static int max = 0;
            public static double average;

            public static void AnalyzeArray(int[] array, ref int max, out double average)
            {

                if (array == null || array.Length == 0)
                {
                    average = 0.0;
                    max = 0;
                    Console.WriteLine($"Average: {average}");
                    Console.WriteLine($"Max: {max}");
                }

                else
                {
                    int SumOfAll = 0;

                    for (int i = 0; array.Length > i; i++)
                    {
                        SumOfAll += array[i];

                        if (array[i] > max)
                        {
                            max = array[i];
                        }
                    }

                    average = (double)SumOfAll / array.Length;

                    Console.WriteLine($"Average: {average}");
                    Console.WriteLine($"Max: {max}");
                }

            }
        }
    }
}
