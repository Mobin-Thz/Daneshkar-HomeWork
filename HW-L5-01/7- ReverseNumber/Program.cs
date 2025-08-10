namespace _7__ReverseNumber
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int reversed = ReverseInteger(number);
                Console.WriteLine(reversed);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        static int ReverseInteger(int x)
        {
            int reversed = 0;

            while (x != 0)
            {
                int pop = x % 10;    // آخرین رقم
                x /= 10;             // حذف آخرین رقم از x

                // چک کردن overflow قبل از اضافه کردن رقم جدید
                if (reversed > int.MaxValue / 10 || (reversed == int.MaxValue / 10 && pop > 7))
                    return 0;

                if (reversed < int.MinValue / 10 || (reversed == int.MinValue / 10 && pop < -8))
                    return 0;

                reversed = reversed * 10 + pop;
            }

            return reversed;
        }
    }

}
