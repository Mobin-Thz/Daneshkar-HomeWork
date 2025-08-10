namespace _5_NumberToText
{
    internal class Program
    {

        static void Main()
        {
            Console.Write("Enter a number between 1 and 9999: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 1 && number <= 9999)
            {
                Console.WriteLine(NumberToWords(number));
            }
            else
            {
                Console.WriteLine("Number out of range or invalid input.");
            }
        }

        static string NumberToWords(int num)
        {
            string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen",
                           "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            string result = "";

            // هزارگان
            if (num >= 1000)
            {
                result += ones[num / 1000] + " Thousand ";
                num %= 1000;
            }

            // صدگان
            if (num >= 100)
            {
                result += ones[num / 100] + " Hundred ";
                num %= 100;
            }

            // دهگان و یکان
            if (num >= 20)
            {
                result += tens[num / 10] + " ";
                num %= 10;
            }

            if (num >= 10 && num < 20)
            {
                result += teens[num - 10] + " ";
                num = 0;
            }

            if (num > 0 && num < 10)
            {
                result += ones[num] + " ";
            }

            return result.Trim();
        }
    }

}

