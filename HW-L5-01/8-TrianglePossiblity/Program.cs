namespace _8_TrianglePossiblity
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Enter the lengths of three sides:");

                int a = ReadPositiveInt("Side a: ");
                int b = ReadPositiveInt("Side b: ");
                int c = ReadPositiveInt("Side c: ");

                Console.WriteLine();

                if (CanFormTriangle(a, b, c))
                {
                    Console.WriteLine($"Yes! A triangle CAN be formed with sides {a}, {b}, and {c}.");
                    Console.WriteLine("Because each side is less than the sum of the other two sides:");
                    Console.WriteLine($" - {a} < {b} + {c} = {b + c}");
                    Console.WriteLine($" - {b} < {a} + {c} = {a + c}");
                    Console.WriteLine($" - {c} < {a} + {b} = {a + b}");
                }
                else
                {
                    Console.WriteLine($"No, a triangle CANNOT be formed with sides {a}, {b}, and {c}.");
                    Console.WriteLine("Because at least one side is NOT less than the sum of the other two sides.");
                }
        }

            static int ReadPositiveInt(string prompt)
            {
                int num;
                while (true)
                {
                    Console.Write(prompt);
                    if (int.TryParse(Console.ReadLine(), out num) && num > 0)
                        return num;
                    Console.WriteLine("Invalid input! Please enter a positive integer.");
                }
            }

            static bool CanFormTriangle(int a, int b, int c)
            {
                return (a < b + c) && (b < a + c) && (c < a + b);
            }
    }

}


