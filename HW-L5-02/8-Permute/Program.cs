namespace _8_Permute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine("All permutations:");
            Permute(input.ToCharArray(), 0, input.Length - 1);
        }

        static void Permute(char[] chars, int left, int right)
        {
            if (left == right)
            {
                Console.WriteLine(new string(chars));
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    Swap(ref chars[left], ref chars[i]);
                    Permute(chars, left + 1, right);
                    Swap(ref chars[left], ref chars[i]); 
                }
            }
        }

        static void Swap(ref char a, ref char b)
        {
            if (a == b) return;
            char temp = a;
            a = b;
            b = temp;
        }
    }
    
}
