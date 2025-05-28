namespace _1_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
            {
            Console.WriteLine("Which Fibonacci number do you want?");
            int n = int.Parse(Console.ReadLine());
            int Fibo = fibonucci(n);
            Console.WriteLine($"{n}th number of Fibo is : {Fibo}");
        }


        static int fibonucci (int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;

            int Prev=1;
            int Current = 2;

            for (int i = 2; i < n; i++)
            {
                Console.WriteLine(Current);
                int next = Prev + Current;
                Prev = Current;
                Current = next;
                

            }
            return Current;
        }
    }
}
